using DarkSoul.Core.Attribute;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DarkSoul.Core.Json
{
    public class JsonConfig
    {
        private string _jsonName;
        private List<Assembly> _assemblies = new List<Assembly>();

        //parse the assembly and get all attributes to parse json
        //if file don't exist
        //get attrribute field default value
        //write file with those data
        //if file exist
        //parse content
        //set variables with this content
        public JsonConfig(string configFileName = "config.json")
        {
            _jsonName = configFileName;
        }

        public void AddAssemblies(params Assembly[] assemblies)
        {
            _assemblies.AddRange(assemblies);
        }

        public void InitConfig()
        {
            if (_assemblies.Count == 0)
                return;
            if(!File.Exists(_jsonName))            
                CreateFile();            
            LoadConfig();
        }

        private void LoadConfig()
        {
            var file = File.ReadAllText(_jsonName);
            foreach (var assembly in _assemblies)
            {
                var fields = assembly.GetTypes()
                      .SelectMany(t => t.GetFields(BindingFlags.GetField | BindingFlags.Public | BindingFlags.Static))
                      .Where(m => m.GetCustomAttributes(typeof(VariableAttribute), false).Count() > 0)
                      .ToArray();
                var settingsClasses = JsonConvert.DeserializeObject<dynamic>(file);
                foreach (var field in fields)
                {
                    if (!field.IsStatic)
                        throw new Exception($"Field {field.Name} in {field.DeclaringType.Name} is not static");
                    //get data from json and set it                    
                    var settingSection = settingsClasses[field.DeclaringType.Name];

                    if(settingSection != null)
                    {
                        var value = JsonConvert.DeserializeObject(JsonConvert.SerializeObject(settingSection[field.Name]));
                        if (value is JArray)
                        {
                            var jArray = (JArray)value;
                            object[] array = jArray.Select(jv => ((dynamic)jv).Value).ToArray();
                            if (array.Length > 0)
                            {
                                var fielType = field.FieldType.GetElementType();
                                if (fielType == typeof(int))
                                    field.SetValue(null, jArray.ToObject<int[]>());
                                else if (fielType == typeof(short))
                                    field.SetValue(null, jArray.ToObject<short[]>());
                                else if (fielType == typeof(long))
                                    field.SetValue(null, jArray.ToObject<long[]>());
                                else if (fielType == typeof(double))
                                    field.SetValue(null, jArray.ToObject<string[]>());
                                else if (fielType == typeof(decimal))
                                    field.SetValue(null, jArray.ToObject<decimal[]>());
                                else if (fielType == typeof(string))
                                    field.SetValue(null, jArray.ToObject<string[]>());
                                else
                                    throw new Exception($"Not managed type {fielType}");
                            }                        
                        }
                        else
                            field.SetValue(null, Convert.ChangeType(value, field.FieldType));
                    }
                }
            }
        }

        private void CreateFile()
        {
            var classDic = new Dictionary<string, Dictionary<string, object>>(); //class name, fieldname, value
            foreach (var assembly in _assemblies)
            {
                var fields = assembly.GetTypes()
                      .SelectMany(t => t.GetFields(BindingFlags.GetField | BindingFlags.Public | BindingFlags.Static))
                      .Where(m => m.GetCustomAttributes(typeof(VariableAttribute), false).Count() > 0)
                      .ToArray();
                foreach (var field in fields)
                {
                    //get data from json and set it
                    var value = field.GetValue(null);
                    if (classDic.TryGetValue(field.DeclaringType.Name, out var list))
                    {
                        list.Add(field.Name, value);
                    }
                    else
                    {
                        classDic.Add(field.DeclaringType.Name, new Dictionary<string, object> {
                            { field.Name, value }
                        });
                    }
                    
                }
            }
            var json = JsonConvert.SerializeObject(classDic, Formatting.Indented);
            File.WriteAllText(_jsonName, json);
        }
    }
}
