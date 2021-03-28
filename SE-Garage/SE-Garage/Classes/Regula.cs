using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Garage.Classes
{
    public enum RuleFields : int
    {
        RULE_FIRST_RULE = -1,

        RULE_APPL_GAMING,
        RULE_APPL_DESIGN,
        RULE_APPL_OFFICE,

        RULE_GAMING_GTAV,
        RULE_GAMING_MINECRAFT,
        RULE_GAMING_FORTNITE,
        RULE_GAMING_LEAGUEOFLEGENDS,
        RULE_GAMING_CSGO,
        RULE_GAMING_PUBG,
        RULE_GAMING_APEXLEGENDS,
        RULE_GAMING_OVERWATCH,
        RULE_GAMING_ROCKETLEAGUE,
        RULE_GAMING_CYBERPUNK2077,
        RULE_GAMING_CODMW,
        RULE_GAMING_WITCHER3,
        RULE_GAMING_TERRARIA,
        RULE_GAMING_BORDERLANDS3,
        RULE_GAMING_STARWARS,

        RULE_GAMING_RUN_DECENT,
        RULE_GAMING_RUN_BINE,
        RULE_GAMING_RUN_FBINE,

        RULE_DESIGN_PHOTOSHOP,
        RULE_DESIGN_ILLUSTRATOR,
        RULE_DESIGN_CORELIDRAW,
        RULE_DESIGN_GIMP,
        RULE_DESIGN_BLENDER,
        RULE_DESIGN_3DSMAX,
        RULE_DESIGN_PAINTSHOP,
        RULE_DESIGN_MAYA,
        
        RULE_OFFICE_STOCARE,
        RULE_OFFICE_VITEZA,
        RULE_OFFICE_AMBELE,

        RULE_LAST_RULE
    }

    class Regula
    {
        public Boolean[] ruleFields;

        public int ruleOutput;

        public Regula()
        {
            ruleFields = new Boolean[(int)RuleFields.RULE_LAST_RULE];

            for (int index = (int)(RuleFields.RULE_FIRST_RULE + 1); index < (int)RuleFields.RULE_LAST_RULE; index++)
            {
                ruleFields[index] = false;
            }

            ruleOutput = 0;
        }

        public Regula(int output)
        {
            ruleFields = new Boolean[(int)RuleFields.RULE_LAST_RULE];

            for(int index = (int)(RuleFields.RULE_FIRST_RULE + 1); index < (int)RuleFields.RULE_LAST_RULE; index++)
            {
                ruleFields[index] = false;
            }

            ruleOutput = output;
        }

        public Regula(Boolean[] fields)
        {
            ruleFields = new Boolean[(int)RuleFields.RULE_LAST_RULE];

            for (int index = (int)(RuleFields.RULE_FIRST_RULE + 1); index < (int)RuleFields.RULE_LAST_RULE; index++)
            {
                ruleFields[index] = fields[index];
            }

            ruleOutput = -1;
        }

        public Regula(Boolean[] fields, int output)
        {
            ruleFields = new Boolean[(int)RuleFields.RULE_LAST_RULE];

            for (int index = (int)(RuleFields.RULE_FIRST_RULE + 1); index < (int)RuleFields.RULE_LAST_RULE; index++)
            {
                ruleFields[index] = fields[index];
            }

            ruleOutput = output;
        }

        public Regula(DataRow row)
        {
            ruleFields = new Boolean[(int)RuleFields.RULE_LAST_RULE];

            for (int index = (int)(RuleFields.RULE_FIRST_RULE + 1); index < (int)RuleFields.RULE_LAST_RULE; index++)
            {
                ruleFields[index] = Convert.ToBoolean(row[index + 1]);
            }
            ruleOutput = Convert.ToInt32(row[33]);
        }

        public void activateField(RuleFields field)
        {
            ruleFields[(int)field] = true;
        }

        public void deactivateField(RuleFields field)
        {
            ruleFields[(int)field] = false;
        }

        public void setField(RuleFields field, Boolean value)
        {
            ruleFields[(int)field] = value;
        }

        public int generateOutput()
        {
            return ruleOutput;
        }

        public void setOutput(int desiredOutput)
        {
            ruleOutput = desiredOutput;
        }

        public void clearRule()
        {
            for (int index = (int)(RuleFields.RULE_FIRST_RULE + 1); index < (int)RuleFields.RULE_LAST_RULE; index++)
            {
                ruleFields[index] = false;
            }

            ruleOutput = 0;
        }
    }
}
