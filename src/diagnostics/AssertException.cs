// Copyright 2004 University of Wisconsin 
// All rights reserved. 
// 
// Contributors: 
//   James Domingo, Forest Landscape Ecology Lab, UW-Madison 

namespace Edu.Wisc.Forest.Flel.Util.Diagnostics
{
    /// <summary>
    /// An exception that is thrown by TraceListener.
    /// </summary>
    public class AssertException
        : System.Exception
    {
        public AssertException(string message)
            : base(message)
        {
        }
    }
}
