// /*
//  * Scientrace by Joep Bos-Coenraad
//  * primarily designed for researching concentrator systems
//  * at the Applied Material Science (AMS) department
//  * at the Radboud University Nijmegen, @see http://www.ru.nl/ams .
//  */

using System;

namespace Scientrace {


public class SubclassResponsibilityException : Exception {

		
	public SubclassResponsibilityException(string str) {
		Console.WriteLine ("Subclass Responsibility. "+str);
	}
}
}
