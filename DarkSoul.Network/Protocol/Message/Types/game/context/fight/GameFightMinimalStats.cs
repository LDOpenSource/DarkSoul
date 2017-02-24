

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightMinimalStats
    {
        public virtual short TypeId => 31;
        
        public uint lifePoints;
        public uint maxLifePoints;
        public uint baseMaxLifePoints;
        public uint permanentDamagePercent;
        public uint shieldPoints;
        public short actionPoints;
        public short maxActionPoints;
        public short movementPoints;
        public short maxMovementPoints;
        public double summoner;
        public bool summoned;
        public short neutralElementResistPercent;
        public short earthElementResistPercent;
        public short waterElementResistPercent;
        public short airElementResistPercent;
        public short fireElementResistPercent;
        public short neutralElementReduction;
        public short earthElementReduction;
        public short waterElementReduction;
        public short airElementReduction;
        public short fireElementReduction;
        public short criticalDamageFixedResist;
        public short pushDamageFixedResist;
        public short pvpNeutralElementResistPercent;
        public short pvpEarthElementResistPercent;
        public short pvpWaterElementResistPercent;
        public short pvpAirElementResistPercent;
        public short pvpFireElementResistPercent;
        public short pvpNeutralElementReduction;
        public short pvpEarthElementReduction;
        public short pvpWaterElementReduction;
        public short pvpAirElementReduction;
        public short pvpFireElementReduction;
        public ushort dodgePALostProbability;
        public ushort dodgePMLostProbability;
        public short tackleBlock;
        public short tackleEvade;
        public short fixedDamageReflection;
        public sbyte invisibilityState;
        
        public GameFightMinimalStats()
        {
        }
        
        public GameFightMinimalStats(uint lifePoints, uint maxLifePoints, uint baseMaxLifePoints, uint permanentDamagePercent, uint shieldPoints, short actionPoints, short maxActionPoints, short movementPoints, short maxMovementPoints, double summoner, bool summoned, short neutralElementResistPercent, short earthElementResistPercent, short waterElementResistPercent, short airElementResistPercent, short fireElementResistPercent, short neutralElementReduction, short earthElementReduction, short waterElementReduction, short airElementReduction, short fireElementReduction, short criticalDamageFixedResist, short pushDamageFixedResist, short pvpNeutralElementResistPercent, short pvpEarthElementResistPercent, short pvpWaterElementResistPercent, short pvpAirElementResistPercent, short pvpFireElementResistPercent, short pvpNeutralElementReduction, short pvpEarthElementReduction, short pvpWaterElementReduction, short pvpAirElementReduction, short pvpFireElementReduction, ushort dodgePALostProbability, ushort dodgePMLostProbability, short tackleBlock, short tackleEvade, short fixedDamageReflection, sbyte invisibilityState)
        {
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.baseMaxLifePoints = baseMaxLifePoints;
            this.permanentDamagePercent = permanentDamagePercent;
            this.shieldPoints = shieldPoints;
            this.actionPoints = actionPoints;
            this.maxActionPoints = maxActionPoints;
            this.movementPoints = movementPoints;
            this.maxMovementPoints = maxMovementPoints;
            this.summoner = summoner;
            this.summoned = summoned;
            this.neutralElementResistPercent = neutralElementResistPercent;
            this.earthElementResistPercent = earthElementResistPercent;
            this.waterElementResistPercent = waterElementResistPercent;
            this.airElementResistPercent = airElementResistPercent;
            this.fireElementResistPercent = fireElementResistPercent;
            this.neutralElementReduction = neutralElementReduction;
            this.earthElementReduction = earthElementReduction;
            this.waterElementReduction = waterElementReduction;
            this.airElementReduction = airElementReduction;
            this.fireElementReduction = fireElementReduction;
            this.criticalDamageFixedResist = criticalDamageFixedResist;
            this.pushDamageFixedResist = pushDamageFixedResist;
            this.pvpNeutralElementResistPercent = pvpNeutralElementResistPercent;
            this.pvpEarthElementResistPercent = pvpEarthElementResistPercent;
            this.pvpWaterElementResistPercent = pvpWaterElementResistPercent;
            this.pvpAirElementResistPercent = pvpAirElementResistPercent;
            this.pvpFireElementResistPercent = pvpFireElementResistPercent;
            this.pvpNeutralElementReduction = pvpNeutralElementReduction;
            this.pvpEarthElementReduction = pvpEarthElementReduction;
            this.pvpWaterElementReduction = pvpWaterElementReduction;
            this.pvpAirElementReduction = pvpAirElementReduction;
            this.pvpFireElementReduction = pvpFireElementReduction;
            this.dodgePALostProbability = dodgePALostProbability;
            this.dodgePMLostProbability = dodgePMLostProbability;
            this.tackleBlock = tackleBlock;
            this.tackleEvade = tackleEvade;
            this.fixedDamageReflection = fixedDamageReflection;
            this.invisibilityState = invisibilityState;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)lifePoints);
            writer.WriteVarInt((int)maxLifePoints);
            writer.WriteVarInt((int)baseMaxLifePoints);
            writer.WriteVarInt((int)permanentDamagePercent);
            writer.WriteVarInt((int)shieldPoints);
            writer.WriteVarShort((int)actionPoints);
            writer.WriteVarShort((int)maxActionPoints);
            writer.WriteVarShort((int)movementPoints);
            writer.WriteVarShort((int)maxMovementPoints);
            writer.WriteDouble(summoner);
            writer.WriteBoolean(summoned);
            writer.WriteVarShort((int)neutralElementResistPercent);
            writer.WriteVarShort((int)earthElementResistPercent);
            writer.WriteVarShort((int)waterElementResistPercent);
            writer.WriteVarShort((int)airElementResistPercent);
            writer.WriteVarShort((int)fireElementResistPercent);
            writer.WriteVarShort((int)neutralElementReduction);
            writer.WriteVarShort((int)earthElementReduction);
            writer.WriteVarShort((int)waterElementReduction);
            writer.WriteVarShort((int)airElementReduction);
            writer.WriteVarShort((int)fireElementReduction);
            writer.WriteVarShort((int)criticalDamageFixedResist);
            writer.WriteVarShort((int)pushDamageFixedResist);
            writer.WriteVarShort((int)pvpNeutralElementResistPercent);
            writer.WriteVarShort((int)pvpEarthElementResistPercent);
            writer.WriteVarShort((int)pvpWaterElementResistPercent);
            writer.WriteVarShort((int)pvpAirElementResistPercent);
            writer.WriteVarShort((int)pvpFireElementResistPercent);
            writer.WriteVarShort((int)pvpNeutralElementReduction);
            writer.WriteVarShort((int)pvpEarthElementReduction);
            writer.WriteVarShort((int)pvpWaterElementReduction);
            writer.WriteVarShort((int)pvpAirElementReduction);
            writer.WriteVarShort((int)pvpFireElementReduction);
            writer.WriteVarShort((int)dodgePALostProbability);
            writer.WriteVarShort((int)dodgePMLostProbability);
            writer.WriteVarShort((int)tackleBlock);
            writer.WriteVarShort((int)tackleEvade);
            writer.WriteVarShort((int)fixedDamageReflection);
            writer.WriteSByte(invisibilityState);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            lifePoints = reader.ReadVarUhInt();
            maxLifePoints = reader.ReadVarUhInt();
            baseMaxLifePoints = reader.ReadVarUhInt();
            permanentDamagePercent = reader.ReadVarUhInt();
            shieldPoints = reader.ReadVarUhInt();
            actionPoints = reader.ReadVarShort();
            maxActionPoints = reader.ReadVarShort();
            movementPoints = reader.ReadVarShort();
            maxMovementPoints = reader.ReadVarShort();
            summoner = reader.ReadDouble();
            summoned = reader.ReadBoolean();
            neutralElementResistPercent = reader.ReadVarShort();
            earthElementResistPercent = reader.ReadVarShort();
            waterElementResistPercent = reader.ReadVarShort();
            airElementResistPercent = reader.ReadVarShort();
            fireElementResistPercent = reader.ReadVarShort();
            neutralElementReduction = reader.ReadVarShort();
            earthElementReduction = reader.ReadVarShort();
            waterElementReduction = reader.ReadVarShort();
            airElementReduction = reader.ReadVarShort();
            fireElementReduction = reader.ReadVarShort();
            criticalDamageFixedResist = reader.ReadVarShort();
            pushDamageFixedResist = reader.ReadVarShort();
            pvpNeutralElementResistPercent = reader.ReadVarShort();
            pvpEarthElementResistPercent = reader.ReadVarShort();
            pvpWaterElementResistPercent = reader.ReadVarShort();
            pvpAirElementResistPercent = reader.ReadVarShort();
            pvpFireElementResistPercent = reader.ReadVarShort();
            pvpNeutralElementReduction = reader.ReadVarShort();
            pvpEarthElementReduction = reader.ReadVarShort();
            pvpWaterElementReduction = reader.ReadVarShort();
            pvpAirElementReduction = reader.ReadVarShort();
            pvpFireElementReduction = reader.ReadVarShort();
            dodgePALostProbability = reader.ReadVarUhShort();
            dodgePMLostProbability = reader.ReadVarUhShort();
            tackleBlock = reader.ReadVarShort();
            tackleEvade = reader.ReadVarShort();
            fixedDamageReflection = reader.ReadVarShort();
            invisibilityState = reader.ReadSByte();
        }
        
    }
    
}