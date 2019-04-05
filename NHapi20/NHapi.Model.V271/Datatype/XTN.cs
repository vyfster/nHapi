using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V271.Datatype
{

///<summary>
/// <p>The HL7 XTN (Extended Telecommunication Number) data type.  Consists of the following components: </p><ol>
/// <li>Telephone Number (XTN)</li>
/// <li>Telecommunication Use Code (ID)</li>
/// <li>Telecommunication Equipment Type (ID)</li>
/// <li>Communication Address (ST)</li>
/// <li>Country Code (SNM)</li>
/// <li>Area/City Code (SNM)</li>
/// <li>Local Number (SNM)</li>
/// <li>Extension (SNM)</li>
/// <li>Any Text (ST)</li>
/// <li>Extension Prefix (ST)</li>
/// <li>Speed Dial Code (ST)</li>
/// <li>Unformatted Telephone number (ST)</li>
/// <li>Effective Start Date (DTM)</li>
/// <li>Expiration Date (DTM)</li>
/// <li>Expiration Reason (CWE)</li>
/// <li>Protection Code (CWE)</li>
/// <li>Shared Telecommunication Identifier (EI)</li>
/// <li>Preference Order (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class XTN : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a XTN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public XTN(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a XTN.
	/// <param name="message">The Message to which this Type belongs</param>
	/// <param name="description">The description of this type</param>
	///</summary>
	public XTN(IMessage message, string description) : base(message, description){
		data = new IType[18];
		data[0] = new ST(message,"Telephone Number");
		data[1] = new ID(message, 201,"Telecommunication Use Code");
		data[2] = new ID(message, 202,"Telecommunication Equipment Type");
		data[3] = new ST(message,"Communication Address");
		data[4] = new SNM(message,"Country Code");
		data[5] = new SNM(message,"Area/City Code");
		data[6] = new SNM(message,"Local Number");
		data[7] = new SNM(message,"Extension");
		data[8] = new ST(message,"Any Text");
		data[9] = new ST(message,"Extension Prefix");
		data[10] = new ST(message,"Speed Dial Code");
		data[11] = new ST(message,"Unformatted Telephone number");
		data[12] = new DTM(message,"Effective Start Date");
		data[13] = new DTM(message,"Expiration Date");
		data[14] = new CWE(message,"Expiration Reason");
		data[15] = new CWE(message,"Protection Code");
		data[16] = new EI(message,"Shared Telecommunication Identifier");
		data[17] = new NM(message,"Preference Order");
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public IType[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="index">The index item to get (zero based)</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///</summary>
	public IType this[int index] { 

get{
		try { 
			return this.data[index]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + index + " doesn't exist in 18 element XTN composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns Telephone Number (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public XTN TelephoneNumber {
get{
	   XTN ret = null;
	   try {
	      ret = (XTN)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Telecommunication Use Code (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID TelecommunicationUseCode {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Telecommunication Equipment Type (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID TelecommunicationEquipmentType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Communication Address (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST CommunicationAddress {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[3];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Country Code (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public SNM CountryCode {
get{
	   SNM ret = null;
	   try {
	      ret = (SNM)this[4];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Area/City Code (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public SNM AreaCityCode {
get{
	   SNM ret = null;
	   try {
	      ret = (SNM)this[5];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Local Number (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public SNM LocalNumber {
get{
	   SNM ret = null;
	   try {
	      ret = (SNM)this[6];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Extension (component #7).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public SNM Extension {
get{
	   SNM ret = null;
	   try {
	      ret = (SNM)this[7];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Any Text (component #8).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST AnyText {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[8];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Extension Prefix (component #9).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST ExtensionPrefix {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[9];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Speed Dial Code (component #10).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SpeedDialCode {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[10];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Unformatted Telephone number (component #11).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST UnformattedTelephoneNumber {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[11];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Effective Start Date (component #12).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DTM EffectiveStartDate {
get{
	   DTM ret = null;
	   try {
	      ret = (DTM)this[12];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Expiration Date (component #13).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DTM ExpirationDate {
get{
	   DTM ret = null;
	   try {
	      ret = (DTM)this[13];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Expiration Reason (component #14).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE ExpirationReason {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)this[14];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Protection Code (component #15).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE ProtectionCode {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)this[15];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Shared Telecommunication Identifier (component #16).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public EI SharedTelecommunicationIdentifier {
get{
	   EI ret = null;
	   try {
	      ret = (EI)this[16];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Preference Order (component #17).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM PreferenceOrder {
get{
	   NM ret = null;
	   try {
	      ret = (NM)this[17];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}