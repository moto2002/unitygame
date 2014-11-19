using System;
using BehaviorLibrary.Components;

namespace BehaviorLibrary
{
    public class StatefulSequence : MulBranchComponent
	{
		private int _LastBehavior = 0;

		/// <summary>
		/// attempts to run the behaviors all in one cycle (stateful on running)
		/// -Returns Success when all are successful
		/// -Returns Failure if one behavior fails or an error occurs
		/// -Does not Return Running
		/// </summary>
		/// <param name="behaviors"></param>
		public StatefulSequence ()
        {
			
		}

		/// <summary>
		/// performs the given behavior
		/// </summary>
		/// <returns>the behaviors return code</returns>
        public override BehaviorReturnCode Behave(InsParam inputParam)
        {

			//start from last remembered position
            for (; _LastBehavior < m_childBehaviorsList.Count; _LastBehavior++)
            {
				try{
                    switch (m_childBehaviorsList[_LastBehavior].Behave(inputParam))
                    {
					case BehaviorReturnCode.Failure:
						_LastBehavior = 0;
						ReturnCode = BehaviorReturnCode.Failure;
						return ReturnCode;
					case BehaviorReturnCode.Success:
						continue;
					case BehaviorReturnCode.Running:
						ReturnCode = BehaviorReturnCode.Running;
						return ReturnCode;
					default:
						_LastBehavior = 0;
						ReturnCode = BehaviorReturnCode.Success;
						return ReturnCode;
					}
				}
				catch (Exception e){
#if DEBUG
					Console.Error.WriteLine(e.ToString());
#endif
					_LastBehavior = 0;
					ReturnCode = BehaviorReturnCode.Failure;
					return ReturnCode;
				}
			}

			_LastBehavior = 0;
			ReturnCode = BehaviorReturnCode.Success;
			return ReturnCode;
		}
	}
}