// Copyright 2004 University of Wisconsin 
// All rights reserved. 
// 
// Contributors: 
//   James Domingo, Forest Landscape Ecology Lab, UW-Madison 

namespace Edu.Wisc.Forest.Flel.Util
{
    public delegate InputValue<T> ReadMethod<T>(StringReader reader,
                                                out int      index);
}
