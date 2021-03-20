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

        public int checkMatchAndGetOutput(Regula lhs, Regula rhs)
        {
            int output = -1;

            if(checkRuleMatch(lhs, rhs))
            {
                int lhsOutput = lhs.generateOutput();
                int rhsOutput = rhs.generateOutput();

                if (lhsOutput != rhsOutput)
                {
                    if (lhsOutput == -1 && rhsOutput != -1)
                    {
                        output = rhsOutput;
                    }
                    else if (lhsOutput != -1 && rhsOutput == -1)
                    {
                        output = lhsOutput;
                    }
                }
                else
                {
                    output = lhsOutput;
                }
            }

            return output;
        }
    }
}
