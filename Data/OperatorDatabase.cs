using R6Schulprojekt.Models;
using System.Collections.Generic;

namespace R6Schulprojekt.Data
{
    public class OperatorDatabase
    {
        public static List<Operator> Operators = new List<Operator>
        {
            #region Attacker
            new Operator("Sledge", new List<Weapon>
            {
                WeaponDatabase.L85A2,
                WeaponDatabase.M590A1
            }),
            new Operator("Thatcher", new List<Weapon>
            {
                WeaponDatabase.L85A2,
                WeaponDatabase.AR33,
                WeaponDatabase.M590A1
            }),
            new Operator("Ash", new List<Weapon>
            {
                WeaponDatabase.R4C,
                WeaponDatabase.G36C
            }),
            new Operator("Thermite", new List<Weapon>
            {
                WeaponDatabase.x556XI
            }),
            new Operator("Twitch", new List<Weapon>
            {
                WeaponDatabase.F2,
                WeaponDatabase.x417
            }),
            new Operator("Montagne", new List<Weapon>
            {
                WeaponDatabase.P9
            }),
            new Operator("Glaz", new List<Weapon>
            {
                WeaponDatabase.OTS03
            }),
            new Operator("Fuze", new List<Weapon>
            {
                WeaponDatabase.x6P41,
                WeaponDatabase.AK12
            }),
            new Operator("IQ", new List<Weapon>
            {
                WeaponDatabase.AUGA2,
                WeaponDatabase.x552COMMANDO,
                WeaponDatabase.G8A1
            }),
            new Operator("Blitz", new List<Weapon>
            {
                WeaponDatabase.P12
            }),
            new Operator("Buck", new List<Weapon>
            {
                WeaponDatabase.C8SFW,
                WeaponDatabase.CAMRS
            }),
            new Operator("Blackbeard", new List<Weapon>
            {
                WeaponDatabase.MK17CQB,
                WeaponDatabase.SR25
            }),
            new Operator("Capitao", new List<Weapon>
            {
                WeaponDatabase.PARA308,
                WeaponDatabase.M249
            }),
            new Operator("Jackal", new List<Weapon>
            {
                WeaponDatabase.C7E,
                WeaponDatabase.PDW9,
                WeaponDatabase.ITA12L
            }),
            new Operator("Zofia", new List<Weapon>
            {
                WeaponDatabase.LMGE,
                WeaponDatabase.M762
            }),
            new Operator("Dokkaebi", new List<Weapon>
            {
                WeaponDatabase.MK14EBR,
                WeaponDatabase.BOSG122
            }),
            new Operator("Lion", new List<Weapon>
            {
                WeaponDatabase.V308,
                WeaponDatabase.x417,
                WeaponDatabase.SGCQB
            }),
            new Operator("Finka", new List<Weapon>
            {
                WeaponDatabase.SPEAR308,
                WeaponDatabase.x6P41
            }),
            new Operator("Maverick", new List<Weapon>
            {
                WeaponDatabase.M4,
                WeaponDatabase.AR1550
            }),
            new Operator("Nomad", new List<Weapon>
            {
                WeaponDatabase.AK74M,
                WeaponDatabase.ARX200
            }),
            new Operator("Gridlock", new List<Weapon>
            {
                WeaponDatabase.F90,
                WeaponDatabase.M249SAW
            }),
            new Operator("Nøkk", new List<Weapon>
            {
                WeaponDatabase.FMG9,
                WeaponDatabase.SIX12SD
            }),
            new Operator("Amaru", new List<Weapon>
            {
                WeaponDatabase.G8A1,
                WeaponDatabase.Supernova
            }),
            new Operator("Iana", new List<Weapon>
            {
                WeaponDatabase.ARX200,
                WeaponDatabase.G36C
            }),
            new Operator("Ace", new List<Weapon>
            {
                WeaponDatabase.AK12
            }),
            new Operator("Striker", new List<Weapon>
            {
                WeaponDatabase.M4,
                WeaponDatabase.M249
            }),
            new Operator("Deimos", new List<Weapon>
            {
                WeaponDatabase.AK74M,
                WeaponDatabase.M590A1
            }),
            new Operator("Ram", new List<Weapon>
            {
                WeaponDatabase.R4C,
                WeaponDatabase.LMGE
            }),
            new Operator("Brava", new List<Weapon>
            {
                WeaponDatabase.PARA308,
                WeaponDatabase.CAMRS
            }),
            new Operator("Grim", new List<Weapon>
            {
                WeaponDatabase.x552COMMANDO,
                WeaponDatabase.SGCQB
            }),
            new Operator("Sens", new List<Weapon>
            {
                WeaponDatabase.x417,
                WeaponDatabase.POF9
            }),
            new Operator("OSA", new List<Weapon>
            {
                WeaponDatabase.x556XI,
                WeaponDatabase.PDW9
            }),
            new Operator("Flores", new List<Weapon>
            {
                WeaponDatabase.AR33,
                WeaponDatabase.SR25
            }),
            new Operator("Zero", new List<Weapon>
            {
                WeaponDatabase.SC3000K,
                WeaponDatabase.MP7
            }),
            new Operator("Kali", new List<Weapon>
            {
                WeaponDatabase.SPSMG9,
                WeaponDatabase.C75AUTO
            }),
            new Operator("Nokk", new List<Weapon>
            {
                WeaponDatabase.FMG9,
                WeaponDatabase.SIX12SD
            }),
            new Operator("Ying", new List<Weapon>
            {
                WeaponDatabase.T95LSW,
                WeaponDatabase.SIX12
            }),
            #endregion

            #region Defender
            new Operator("Kapkan", new List<Weapon>
            {
                WeaponDatabase.x9X19VSN,
                WeaponDatabase.SASG12
            }),
            new Operator("Bandit", new List<Weapon>
            {
                WeaponDatabase.MP7,
                WeaponDatabase.M870
            }),
            new Operator("Jäger", new List<Weapon>
            {
                WeaponDatabase.x416CCarbine,
                WeaponDatabase.M870
            }),
            new Operator("Frost", new List<Weapon>
            {
                WeaponDatabase.SUPER90,
                WeaponDatabase.x9MMC1
            }),
            new Operator("Valkyrie", new List<Weapon>
            {
                WeaponDatabase.MPX,
                WeaponDatabase.SPAS12
            }),
            new Operator("Caveira", new List<Weapon>
            {
                WeaponDatabase.M12,
                WeaponDatabase.SPAS15
            }),
            new Operator("Hibana", new List<Weapon>
            {
                WeaponDatabase.TYPE89,
                WeaponDatabase.Supernova
            }),
            new Operator("Echo", new List<Weapon>
            {
                WeaponDatabase.MP5SD,
                WeaponDatabase.Supernova
            }),
            new Operator("Mira", new List<Weapon>
            {
                WeaponDatabase.Vector45ACP,
                WeaponDatabase.ITA12L
            }),
            new Operator("Lesion", new List<Weapon>
            {
                WeaponDatabase.T5SMG,
                WeaponDatabase.SIX12SD
            }),
            new Operator("Vigil", new List<Weapon>
            {
                WeaponDatabase.K1A,
                WeaponDatabase.BOSG122
            }),
            new Operator("Alibi", new List<Weapon>
            {
                WeaponDatabase.MX4STORM,
                WeaponDatabase.ACS12
            }),
            new Operator("Clash", new List<Weapon>
            {
                WeaponDatabase.SPSMG9,
                WeaponDatabase.SUPERSHORTY,
                WeaponDatabase.P10C
            }),
            new Operator("Kaid", new List<Weapon>
            {
                WeaponDatabase.TCSG12,
                WeaponDatabase.AUGA3
            }),
            new Operator("Mozzie", new List<Weapon>
            {
                WeaponDatabase.COMMANDO9,
                WeaponDatabase.P10RONI
            }),
            new Operator("Warden", new List<Weapon>
            {
                WeaponDatabase.MPX,
                WeaponDatabase.M590A1
            }),
            new Operator("Maestro", new List<Weapon>
            {
                WeaponDatabase.ALDA556,
                WeaponDatabase.ACS12
            }),
            new Operator("Goyo", new List<Weapon>
            {
                WeaponDatabase.Vector45ACP,
                WeaponDatabase.TCSG12
            }),
            new Operator("Oryx", new List<Weapon>
            {
                WeaponDatabase.T5SMG,
                WeaponDatabase.SPAS12
            }),
            new Operator("Melusi", new List<Weapon>
            {
                WeaponDatabase.MP5,
                WeaponDatabase.SUPER90
            }),
            new Operator("Aruni", new List<Weapon>
            {
                WeaponDatabase.P10RONI,
                WeaponDatabase.MK14EBR
            }),
            new Operator("Azami", new List<Weapon>
            {
                WeaponDatabase.ACS12,
                WeaponDatabase.x9X19VSN
            }),
            new Operator("Skopos", new List<Weapon>
            {
                WeaponDatabase.PCX33
            }),
            new Operator("Sentry", new List<Weapon>
            {
                WeaponDatabase.COMMANDO9,
                WeaponDatabase.M850

            }),
            new Operator("Tubarao", new List<Weapon>
            {
                WeaponDatabase.MPX,
                WeaponDatabase.AR1550
            }),
            new Operator("Fenrir", new List<Weapon>
            {
                WeaponDatabase.MP7,
                WeaponDatabase.SASG12
            }),
            new Operator("Solis", new List<Weapon>
            {
                WeaponDatabase.ITA12L,
                WeaponDatabase.P90,
                WeaponDatabase.SMG11
            }),
            new Operator("Thorn", new List<Weapon>
            {
                WeaponDatabase.UZK50GI,
                WeaponDatabase.M870
            }),
            new Operator("Thunderbird", new List<Weapon>
            {
                WeaponDatabase.SPEAR308,
                WeaponDatabase.SPAS15
            }),
            new Operator("Wamai", new List<Weapon>
            {
                WeaponDatabase.AUGA2,
                WeaponDatabase.MP5K
            }),
            new Operator("Ela", new List<Weapon>
            {
                WeaponDatabase.SCROPIONEVO,
                WeaponDatabase.FO12
            }),
            new Operator("Mute", new List<Weapon>
            {
                WeaponDatabase.MP5K,
                WeaponDatabase.M590A1
            }),
            new Operator("Smoke", new List<Weapon>
            {
                WeaponDatabase.SMG11,
                WeaponDatabase.M590A1,
                WeaponDatabase.FMG9
            }),
            new Operator("Castle", new List<Weapon>
            {
                WeaponDatabase.UMP45,
                WeaponDatabase.M1014
            }),
            new Operator("Pulse", new List<Weapon>
            {
                WeaponDatabase.UMP45,
                WeaponDatabase.M1014
            }),
            new Operator("DOC", new List<Weapon>
            {
                WeaponDatabase.MP5,
                WeaponDatabase.P90,
                WeaponDatabase.SGCQB
            }),
            new Operator("Rook", new List<Weapon>
            {
                WeaponDatabase.MP5,
                WeaponDatabase.P90,
                WeaponDatabase.SGCQB
            }),
            new Operator("Tachanka", new List<Weapon>
            {
                WeaponDatabase.DP27,
                WeaponDatabase.x9X18VSN
            })
            #endregion
        };

    }
}
