using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class dataBase {
    [XmlAttribute("name")] //name of compound
    public string name;

    [XmlElement("charge1")] // charge of compound
    public int charge1;

    [XmlElement("charge2")] //charge of compound if multi valent
    public int charge2;

    [XmlElement("chargeType")] //pos or neg charge
    public bool chargeType;

    [XmlElement("atomicNo")] //atomic number for elements
    public int atomicNo;

    [XmlElement("compoundState")] //solid, liquid, gas
    public int compundState;

    [XmlElement("compoundType")] //element, ionic, molecular
    public int compundType;

    [XmlElement("positionAC")]
    public int positionAC;
}

