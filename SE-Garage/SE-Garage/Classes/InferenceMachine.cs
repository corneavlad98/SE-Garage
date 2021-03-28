using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Garage.Classes
{
    class InferenceMachine
    {
        public Boolean checkRuleMatch(Regula lhs, Regula rhs)
        {
            Boolean match = true;

            if (lhs.ruleFields.Length != rhs.ruleFields.Length)
            {
                match = false;
            }
            else
            {
                for (int index = (int)(RuleFields.RULE_FIRST_RULE + 1); index < (int)(RuleFields.RULE_LAST_RULE) && match; index++)
                {
                    if (lhs.ruleFields[index] != rhs.ruleFields[index])
                    {
                        match = false;
                    }
                }
            }

            return match;
        }

        public List<int> checkRuleAgainstKnowledgeBase(List<Regula> kb, Regula regula)
        {
            List<int> output = new List<int>();

            foreach(Regula currentRule in kb)
            {
                if(checkRuleMatch(currentRule, regula))
                {
                    output.Add(currentRule.generateOutput());
                }
            }

            return output;
        }
    }
}
