<div id="top"></div>


[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://diginenergi.no/">
    <img src="images/DIGIN_logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">The DIGIN program is the Norwegian grid operators' digitalisation initiative, where Norwegian DSOs, the TSO, regulator and others have joined forces to create the fundament for full digital interaction in both planning and operation of the electrical grid. 
  </h3>


  <p align="center">
   Development work in DIGIN is organized as coordinated work packages, all supporting the overall vision of the program.
    <br />
    <a href="https://github.com/digin-energi/produktdata-public"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/digin-energi/produktdata-public/issues">Report Bug</a>
    ·
    <a href="https://github.com/digin-energi/produktdata-public/issues">Request Feature Enhancement</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->

<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#usecases">Usecases</a></li>
      </ul>
    </li>
    <li>
      <a href="#iec-61968-4-scope">IEC 61968-4 Scope</a>
      <ul>
        <li><a href="#assetcatalogue-message">AssetCatalogue Message</a></li>
        <li><a href="#digin-extensions">DIGIN Extensions</a></li>
      </ul>
    </li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#tools-and-examples">Tools and Examples</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#versioning">Versioning</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

The 'Product data project' is a project under the DIGIN program. Deliverables from this project will enable automated exchange of data related to planning and operation of the electrical grid. The project is working with standard exchange formats for data such as: :

* Product data 
* Descriptions (requirements) of functions for grid equipment required when purchasing
* Test protocol data (FAT/SAT)
* Data about components of grid equipment (asset data)

Automated exchange of data will improve data quality and simplify current manual registration processes.

Centralized publishing of new and historic product data is another goal for the project. This will avoid establishment of redundant databases for standard data at the grid operators, contractors, and manufacturers. 

CIM, the standard for exchange of power systems related information (data), has been extended to cover the data needs of the DSOs. 

The outcome of the project is: 
* A dedicated CIM profile to be used by the DSOs and product suppliers (IEC 61968-4:2019), adapted to the Norwegian industry
* An increasing number of standard products which can exchange data according to CIM
* Standard schemas (XML) for exchange of data according to CIM 
* A validation tool, assuring data transfer and -formats are according to CIM



<p align="right">(<a href="#top">back to top</a>)</p>

<!-- USECASES -->
### Usecases

An AssetCatalogue is a collection of information regarding available types of products and materials that are used to build or install assets, to maintain assets or to operate assets.  

Each catalogue item is for a specific product available from a specific manufacturer. Herein, the AssetCatalogue usecase is further divided into two scenarios:
* AssetShipmentCatalogue - The target AssetCatalogue message within the scenario may contain reference information such as weight, dimennsions, drawingNumber and modelNumber about a specific ProductAssetModel.
* AssetSpecificationCatalogue - The target AssetCatalogue message within the scenario may contain reference information such as typeOfCooling, minSoundPressureLevel and paintThickness about a specific ProductAssetModel as well as the AssetInfo rating information for it.

The AssetCatalogue message is used to exchange asset catalogue information. Example applications include replacement of generic assets and long term planning. 
* While installing assets, a maintenance person may query the catalogue for a specific product model of interest. 
* In long term planning, a project may have a set of requirements and the organisation’s catalogue of approved product models is used as a basis of decision-making. 

An engineer or analytic queries the catalogue and applies the selection rules in order to identify catalogue items with specifications that meet the project requirements

*This section should list any usecase and their related explanation used to bootstrap the project. Leave any related usecase for the development and enhancement.*

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## IEC 61968-4 Scope

This part of IEC 61968 specifies the information content of a set of message types that can be used to support many of the business functions related to records and asset management. Typical uses of the message types defined in this Part of IEC 61968 include network extension planning, copying feeder or other network data between systems, network or diagram edits and asset inspection. Message types defined in other Parts of IEC 61968 may also be relevant to these use cases.

### AssetCatalogue Message

The AssetCatalogue message contains an information of a Product modelled within ProductAssetModel CIM Class. Following are the assets which can be associated to a ProductAssetModel:

* Power Transformer
* End Device
* Circuit Breakers
* Disconnectors
* Fuses
* Cables
* Overhead Lines
* Bushing
* Earth ground wire
* Auxiliary Equipment
* Compensators
* Conductors
* Connectors
* End Devices
* Generators
* Protection Devices
* Structure Devices
* Switchgear
* Terminations
* Current Transfomers
* Voltage Transformers

### DIGIN Extensions
In this project, for the two above mentioned scenarios - ProductShipmentCatalogue and ProductRequirementCatalogue, the metamodel extensions are being developed by the DIGIN team after deep consideration on the concerns of the Distribution System Operators (DSOs) and vendors. 

The extensions developed within DIGIN Produktdata workstream have ***http://digin.no/DIGIN/CIM100Extension/1/0#*** namespace. 

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- ROADMAP -->
## Roadmap

The project has a plan to undergo the enhancement of each aforementioned product asset. Following is the short term development plan of the DIGIN Team and achievements:

#### General Extensions

- [x] AssetSpecification Class, which is aggregation of other AssetInfo elements such as electrical, dimensional, protective and audiable parameters. Follow are the UML diagram and detailed XML schema. 


<ol><details><ul>
<details><summary>UML Class Diagram</summary><p>
<p align="center"><img src="images/AssetSpecification.png" width="500" ></p>
</p></details>

<details><summary>AssetSpecification Class</summary><p>

```xml
<xs:complexType name="AssetSpecification" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetSpecification">
  <xs:annotation>
    <xs:documentation>AssetSpecification Class, which is aggregation of other AssetInfo elements such as electrical, dimensional, protective and audiable parameters. </xs:documentation>
    <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
  </xs:annotation>
  <xs:complexContent mixed="false">
    <xs:extension base="m:IdentifiedObject">
      <xs:sequence>
        <xs:element minOccurs="0" maxOccurs="unbounded" name="CoolingInfos" type="m:CoolingInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetSpecification.CoolingInfos">
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="unbounded" name="MeticInfos" type="m:MetricInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetSpecification.MeticInfos">
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="unbounded" name="SoundInfos" type="m:SoundInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetSpecification.SoundInfos">
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="unbounded" name="SurfaceTreatmentInfos" type="m:SurfaceTreatmentInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetSpecification.SurfaceTreatmentInfos">
        </xs:element>
      </xs:sequence>
    </xs:extension>
  </xs:complexContent>
</xs:complexType>
```
</p></details>

<details><summary>CoolingInfo Class </summary><p>

```xml
<xs:complexType name="CoolingInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/CoolingInfo">
  <xs:annotation>
    <xs:documentation>Description of the assets cooling method or principles.</xs:documentation>
    <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
  </xs:annotation>
  <xs:complexContent mixed="false">
    <xs:extension base="m:AssetInfo">
      <xs:sequence>
        <xs:element minOccurs="0" maxOccurs="1" name="typeOfCooling" type="xs:string" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/CoolingInfo.typeOfCooling">
          <xs:annotation>
            <xs:documentation>Type of transformer cooling class (four letter code ONAN, ONAF etc.) or any other cooling type or system used on the asset. </xs:documentation>
            <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:extension>
  </xs:complexContent>
</xs:complexType>
```
</p></details>

<details><summary>MetricInfo Class</summary><p>

```xml
<xs:complexType name="MetricInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/MetricInfo">
  <xs:annotation>
    <xs:documentation>Dimensions and weight of an asset.</xs:documentation>
    <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
  </xs:annotation>
  <xs:complexContent mixed="false">
    <xs:extension base="m:AssetInfo">
      <xs:sequence>
        <xs:element minOccurs="0" maxOccurs="1" name="metricType" type="m:ContextKind" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/MetricInfo.metricType">
          <xs:annotation>
            <xs:documentation>The kind of context dimension and weight applies to. </xs:documentation>
            <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="productDiameter" type="m:Length" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/MetricInfo.productDiameter">
          <xs:annotation>
            <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="productHieght" type="m:Length" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/MetricInfo.productHieght">
          <xs:annotation>
            <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="productLength" type="m:Length" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/MetricInfo.productLength">
          <xs:annotation>
            <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="productWeight" type="m:Mass" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/MetricInfo.productWeight">
          <xs:annotation>
            <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="productWidth" type="m:Length" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/MetricInfo.productWidth">
          <xs:annotation>
            <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:extension>
  </xs:complexContent>
</xs:complexType>
```
</p></details>

<details><summary>SoundInfo Class</summary><p>

```xml
<xs:complexType name="SoundInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/SoundInfo">
  <xs:annotation>
    <xs:documentation>Information about protective measures against corrosion used on the asset surface </xs:documentation>
    <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
  </xs:annotation>
  <xs:complexContent mixed="false">
    <xs:extension base="m:AssetInfo">
      <xs:sequence>
        <xs:element minOccurs="0" maxOccurs="1" name="minSoundPressureLevel" type="m:Pressure" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/SoundInfo.minSoundPressureLevel">
          <xs:annotation>
            <xs:documentation>Lowest possible sound pressure level in dB(A) according to IEC 60076-10 </xs:documentation>
            <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:extension>
  </xs:complexContent>
</xs:complexType>
```
</p></details>

<details><summary>SurfaceTreatmentInfo Class</summary><p>

```xml
<xs:complexType name="SurfaceTreatmentInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/SurfaceTreatmentInfo">
  <xs:annotation>
    <xs:documentation>Information about sound emission from the asset during normal operation.</xs:documentation>
    <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
  </xs:annotation>
  <xs:complexContent mixed="false">
    <xs:extension base="m:AssetInfo">
      <xs:sequence>
        <xs:element minOccurs="0" maxOccurs="1" name="galvanizationThickness" type="m:Length" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/SurfaceTreatmentInfo.galvanizationThickness">
          <xs:annotation>
            <xs:documentation>Thickness of galvanization on the asset surface.</xs:documentation>
            <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="paintThickness" type="m:Length" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/SurfaceTreatmentInfo.paintThickness">
          <xs:annotation>
            <xs:documentation>Thickness of paint on the asset surface.</xs:documentation>
            <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:extension>
  </xs:complexContent>
</xs:complexType>
```
</p></details>

<details><summary>ContextKind Enumeration</summary><p>

```xml
<xs:simpleType name="ContextKind" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/ContextKind">
  <xs:annotation>
    <xs:documentation cimp:category="Stereotype" cimp:notes="Specifies an enumerated type">enumeration</xs:documentation>
    <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
  </xs:annotation>
  <xs:restriction base="xs:string">
    <xs:enumeration value="installed">
    </xs:enumeration>
    <xs:enumeration value="inStock">
    </xs:enumeration>
    <xs:enumeration value="shipping">
    </xs:enumeration>
    <xs:enumeration value="universal">
    </xs:enumeration>
  </xs:restriction>
</xs:simpleType>
```
</p></details>

</ul></details></ol>

- [x] AssetInfoContainer Class, which is aggregation two or more AssetInfo contained within a single product. Follow are the UML diagram and detailed XML schema. 
<ol><details><ul>


<details><summary>AssetInfoContainer Class</summary><p>

```xml
<xs:complexType name="AssetInfoContainer" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer">
  <xs:annotation>
    <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
  </xs:annotation>
  <xs:complexContent mixed="false">
    <xs:extension base="m:AssetInfo">
      <xs:sequence>
        <xs:choice maxOccurs="unbounded" minOccurs="0"><xs:element minOccurs="0" maxOccurs="unbounded" name="BusbarSectionInfo" type="m:BusbarSectionInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element><xs:element minOccurs="0" maxOccurs="unbounded" name="BushingInfo" type="m:BushingInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element><xs:element minOccurs="0" maxOccurs="unbounded" name="CableInfo" type="m:CableInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element><xs:element minOccurs="0" maxOccurs="unbounded" name="ConcentricNeutralCableInfo" type="m:ConcentricNeutralCableInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element><xs:element minOccurs="0" maxOccurs="unbounded" name="InterrupterUnitInfo" type="m:InterrupterUnitInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element><xs:element minOccurs="0" maxOccurs="unbounded" name="OperatingMechanismInfo" type="m:OperatingMechanismInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element><xs:element minOccurs="0" maxOccurs="unbounded" name="PowerTransformerInfo" type="m:PowerTransformerInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element><xs:element minOccurs="0" maxOccurs="unbounded" name="ShuntCompensatorInfo" type="m:ShuntCompensatorInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element><xs:element minOccurs="0" maxOccurs="unbounded" name="SwitchInfo" type="m:SwitchInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element><xs:element minOccurs="0" maxOccurs="unbounded" name="TapChangerInfo" type="m:TapChangerInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element><xs:element minOccurs="0" maxOccurs="unbounded" name="TapeShieldCableInfo" type="m:TapeShieldCableInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element><xs:element minOccurs="0" maxOccurs="unbounded" name="WireInfo" type="m:WireInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINAssetSpecification/AssetInfoContainer.AssetInfo">
        </xs:element></xs:choice>
      </xs:sequence>
    </xs:extension>
  </xs:complexContent>
</xs:complexType>
```
</p></details>
</ul></details></ol>

#### Product Extensions

The DIGIN teams has made a following prioritisation of the development product extentions. The details of the extention in terms of UML diagrams and XML schema are also presented.

Tags related to development 

`completed` means the extension task has finalised by the development team and open for discussion and further enhancement, 

`planned` means the given product is next target development, and

`inprogress` means the given product is in ehnacement phase 



<!-- Power TRansfomer -->
1. [x] PowerTransformer 

<ol><ul><details><summary> Transfomer (completed) </summary><ul>
<details><summary>UML Class Diagram</summary><p>
<p align="center"><img src="images/PowerTransformer Product.png" width="500" ></p>
</p></details>

<details><summary>TransformerTankInfo Class</summary><p>

```xml
<xs:complexType name="TransformerTankInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/TransformerTankInfo">
  <xs:annotation>
    <xs:documentation>Set of transformer tank data, from an equipment library.</xs:documentation>
  </xs:annotation>
  <xs:sequence>
    <xs:element minOccurs="0" maxOccurs="1" name="insolutionType" type="m:TransformerTankInsulationKind" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINTransformer/DIGINTransformerTankInfo.insolutionType">
      <xs:annotation>
        <xs:documentation>Kind of insulation used in the transformer tank.</xs:documentation>
        <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
      </xs:annotation>
    </xs:element>
    <xs:element minOccurs="1" maxOccurs="unbounded" name="TransformerEndInfos" type="m:TransformerEndInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/TransformerTankInfo.TransformerEndInfos">
      <xs:annotation>
        <xs:documentation>Data for all the ends described by this transformer tank data.</xs:documentation>
      </xs:annotation>
    </xs:element>
  </xs:sequence>
</xs:complexType>
```
</p></details>

<details><summary>TransformerTankInsulationKind Enumeration</summary><p>

```xml
<xs:simpleType name="TransformerTankInsulationKind" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtDigPro/DIGINTransformer/TransformerTankInsulationKind">
  <xs:annotation>
    <xs:documentation cimp:category="Stereotype">DIGIN</xs:documentation>
    <xs:documentation cimp:category="Stereotype" cimp:notes="Specifies an enumerated type">enumeration</xs:documentation>
  </xs:annotation>
  <xs:restriction base="xs:string">
    <xs:enumeration value="dry-type">
    </xs:enumeration>
    <xs:enumeration value="gas-filled">
    </xs:enumeration>
    <xs:enumeration value="liquid-immersed">
    </xs:enumeration>
  </xs:restriction>
</xs:simpleType>
```
</p></details>

</ul></details></ul></ol>

<!-- End Devices -->
2. [ ] End Devices
<ol><ul><details><summary>EndDevice (planned) </summary><ul>
</ul></details></ul></ol>

<!-- Lines -->
3. [ ] Lines
<ol><ul><details><summary>Conductors</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>Cables (inprogress) </summary><ul>
<details><summary>CableInfo Class</summary><p>
conductingCrossSection and isSubmarine attributes are added as NEK extension to CableInfo Class.

```xml
<xs:complexType name="CableInfo" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/CableInfo">
  <xs:annotation>
    <xs:documentation>Cable data.</xs:documentation>
  </xs:annotation>
  <xs:complexContent mixed="false">
    <xs:extension base="m:WireInfo">
      <xs:sequence>
        <xs:element minOccurs="0" maxOccurs="1" name="conductingCrossSection" type="m:Area" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtFos/NEKLine/NEKCableInfo.conductingCrossSection">
          <xs:annotation>
            <xs:documentation>The conduction nominal cross-section area accordance with IEC 60228.</xs:documentation>
            <xs:documentation cimp:category="Stereotype" cimp:notes="NEK">NEK</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="constructionKind" type="m:CableConstructionKind" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/CableInfo.constructionKind">
          <xs:annotation>
            <xs:documentation>Kind of construction of this cable.</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="diameterOverCore" type="m:Length" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/CableInfo.diameterOverCore">
          <xs:annotation>
            <xs:documentation>Diameter over the core, including any semi-con screen; should be the insulating layer's inside diameter.</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="diameterOverInsulation" type="m:Length" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/CableInfo.diameterOverInsulation">
          <xs:annotation>
            <xs:documentation>Diameter over the insulating layer, excluding outer screen.</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="diameterOverJacket" type="m:Length" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/CableInfo.diameterOverJacket">
          <xs:annotation>
            <xs:documentation>Diameter over the outermost jacketing layer.</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="diameterOverScreen" type="m:Length" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/CableInfo.diameterOverScreen">
          <xs:annotation>
            <xs:documentation>Diameter over the outer screen; should be the shield's inside diameter.</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="isStrandFill" type="xs:boolean" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/CableInfo.isStrandFill">
          <xs:annotation>
            <xs:documentation>True if wire strands are extruded in a way to fill the voids in the cable.</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="isSubmarine" type="xs:boolean" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtFos/NEKLine/NEKCableInfo.isSubmarine">
          <xs:annotation>
            <xs:documentation>Flag to indicate if this is a submarine cable.</xs:documentation>
            <xs:documentation cimp:category="Stereotype" cimp:notes="NEK">NEK</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="nominalTemperature" type="m:Temperature" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/CableInfo.nominalTemperature">
          <xs:annotation>
            <xs:documentation>Maximum nominal design operating temperature.</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="outerJacketKind" type="m:CableOuterJacketKind" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/CableInfo.outerJacketKind">
          <xs:annotation>
            <xs:documentation>Kind of outer jacket of this cable.</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="sheathAsNeutral" type="xs:boolean" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/CableInfo.sheathAsNeutral">
          <xs:annotation>
            <xs:documentation>True if sheath / shield is used as a neutral (i.e., bonded).</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs="0" maxOccurs="1" name="shieldMaterial" type="m:CableShieldMaterialKind" sawsdl:modelReference="http://iec.ch/TC57/CIM100#TC57CIM/IEC61968/AssetInfo/CableInfo.shieldMaterial">
          <xs:annotation>
            <xs:documentation>Material of the shield.</xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:extension>
  </xs:complexContent>
</xs:complexType>
```
</p></details>

<details><summary>Wire Class</summary><p>
nominalTemperature attribute is added as NEK extension the WireInfo Class

```xml
    <xs:extension base="m:WireInfo">
      <xs:sequence>
        <xs:element minOccurs="0" maxOccurs="1" name="nominalTemperature" type="m:Temperature" sawsdl:modelReference="http://iec.ch/TC57/CIM100#NorwegianCIMExtensions/ExtFos/NEKLine/NEKOverheadWireInfo.nominalTemperature">
          <xs:annotation>
            <xs:documentation>Maximum nominal design operating temperature.</xs:documentation>
            <xs:documentation cimp:category="Stereotype" cimp:notes="NEK">NEK</xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:extension>
```
</p></details>

</ul></details></ul></ol>

<ol><ul><details><summary>OverheadLines</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>EarthGroundWire</summary><ul>
</ul></details></ul></ol>

<!-- Switchgear -->
4. [ ] Switchgear	

<ol><ul><details><summary>Disconnector</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>GroundDisconnector</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>Jumper</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>Clamp</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>Fuse</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>Breaker</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>Recloser</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>LoadBreakSwitch</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>InterrupterUnit</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>OperatingMechanism</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>CircuitBreakers</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>Disconnectors</summary><ul>
</ul></details></ul></ol>

<!-- Auxiliary Equipment -->
5. [ ] Auxiliary Equipment	

<ol><ul><details><summary>CurrentTransformer</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>PostLineSensor</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>PotentialTransformer</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>WaveTrap</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>SurgeArrester</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>FaultIndicator</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>AirCompressor</summary><ul>
</ul></details></ul></ol>

<!-- Structure Devices -->
6. [ ] Structure Devices	

<ol><ul><details><summary>PrefabricatedBuilding</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>CableCabinet</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>Pole</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>Crossarm</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>Insulator</summary><ul>
</ul></details></ul></ol>

<!-- Connectors -->
7. [ ] Connectors	
 
<ol><ul><details><summary>Connector</summary><ul>
</ul></details></ul></ol>
 
<ol><ul><details><summary>Termination</summary><ul>
</ul></details></ul></ol>
 
<ol><ul><details><summary>Joint</summary><ul>
</ul></details></ul></ol>
 
<ol><ul><details><summary>Bushing</summary><ul>
</ul></details></ul></ol>

<!-- Compensator -->
8. [ ] Compensators	

<ol><ul><details><summary>SeriesCompensator</summary><ul>
</ul></details></ul></ol>

<ol><ul><details><summary>ShuntCompensator</summary><ul>
</ul></details></ul></ol>
 
<ol><ul><details><summary>PetersenCoil</summary><ul>
</ul></details></ul></ol>

<!-- Protection Equipment -->
9. [ ] ProtectionEquipment
<ol><ul><details><summary>ProtectionEquipment</summary><ul>
</ul></details></ul></ol>

<!-- Generators -->
10. [ ] Generators
<ol><ul><details><summary>Generators</summary><ul>
</ul></details></ul></ol>



See the [open issues](https://github.com/digin-energi/produktdata-public/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTRIBUTION -->
## Tools and Examples

### Tools
#### XSD Diagram
* XSD Diagram is a free Xml Schema Definition (XSD) diagram viewer for Windows written in C# Framework.NET 2.0.

* This program is free software and may be distributed according to the terms * of the GNU General Public License (GPL).

* The latest source code is available at github.com/dgis/xsddiagram

* For download and use, follow the instruction at http://regis.cosnier.free.fr/?page=XSDDiagram

#### CIMTool
* CIMTool is an open source tool that supports the Common Information Model (CIM) standards used in the electric power industry. It is potentially useful for other semantic applications too. CIMTool can be downloaded in several forms from the https://wiki.cimtool.org/Download.html 

#### CimConteXtor
* This product is an opensource product governed by a group of  companies under the leadership of ENTSO-E.

* You can get the source code on request  under the GPL license CeCill-B  ( manuals), however, you can download the addins from https://www.cimcontextor.net/

* CimConteXtor is an add-in to “Sparx Systems Enterprise Architect” (EA) product which exists since 2010.

* It extends EA functionalities by providing a framework that allows creation and management of UML profiles "based on" existing UML models, and helps you to do these profiles according to a rigorous methodology that is explained in the Annex of CimConteXtor user manual.

#### DIGIN Energi Validation Tool
* As a part of the DIGIN Energi, DNV has developed a XML validator for validating a XML file against a XSD file. The validation results a written in a text file which can be opened and viewed by any text editor (e.g. notepad).
* The validation can be done in 2 ways, with or without self-provided xml schema.
* The tool is open source and can be downloaded from https://github.com/digin-energi/Produktdata/blob/main/validationtool/XmlXsdValidator.exe 

### Examples

<details><summary>Example of DSO Transformer Specification</summary><p>

```xml
<?xml version="1.0" encoding="UTF-8"?>
<m:AssetCatalogue xmlns:m="http://digin.no/DIGIN/CIM100Extenstion/1/0#" 
xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" 
xsi:schemaLocation="http://digin.no/DIGIN/CIM100Extenstion/1/0# ../Schema/DIGINProfile_iec61968_part4_TransformerProductData_v026.xsd ">
	<m:ProductAssetModel>
		<m:mRID>fd5f73f3-622a-4e7d-ac37-b07a642b14e6</m:mRID>
		<m:Names>
			<m:name>22_415_500 Model</m:name>
		</m:Names>
		<m:AssetSpecification>
			<m:CoolingInfo>
				<m:typeOfCooling>ONAN</m:typeOfCooling>
			</m:CoolingInfo>
			<m:SoundInfo>
				<m:minSoundPressureLevel unit="dB">60</m:minSoundPressureLevel>
			</m:SoundInfo></m:AssetSpecification>
		<m:AssetInfoContainer>
			<m:PowerTransformerInfo>
				<m:kind>transformer</m:kind>
				<m:TransformerTankInfos>
					<m:insulationKind>liquid-immersed</m:insulationKind>
					<m:TransformerEndInfos>
						<m:connectionKind>D</m:connectionKind>
						<m:endNumber>1</m:endNumber>
						<m:ratedS unit="VA" multiplier="k">500</m:ratedS>
						<m:ratedU unit="V" multiplier="k">22</m:ratedU>
						<m:EnergisedEndNoLoadTests>
							<m:loss unit="W">500</m:loss></m:EnergisedEndNoLoadTests>
						<m:EnergisedEndShortCircuitTests>
							<m:power unit="VA">4000</m:power>
							<m:voltage>4</m:voltage></m:EnergisedEndShortCircuitTests></m:TransformerEndInfos>
					<m:TransformerEndInfos>
						<m:connectionKind>Yn</m:connectionKind>
						<m:endNumber>2</m:endNumber>
						<m:phaseAngleClock>11</m:phaseAngleClock>
						<m:ratedS unit="VA" multiplier="k">500</m:ratedS>
						<m:ratedU unit="V">415</m:ratedU></m:TransformerEndInfos>
				</m:TransformerTankInfos>
			</m:PowerTransformerInfo>
			<m:TapChangerInfo>
				<m:kind>other</m:kind>
				<m:highStep>7</m:highStep>
				<m:lowStep>4</m:lowStep>
				<m:neutralStep>0</m:neutralStep>
				<m:stepVoltageIncrement>2.5</m:stepVoltageIncrement>
			</m:TapChangerInfo></m:AssetInfoContainer></m:ProductAssetModel></m:AssetCatalogue>
```
</p></details>

<details><summary>Example of Manufacturer Transformer Shipment</summary><p>

```xml
<?xml version="1.0" encoding="UTF-8"?>
<m:AssetCatalogue xmlns:m="http://digin.no/DIGIN/CIM100Extenstion/1/0#" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://digin.no/DIGIN/CIM100Extenstion/1/0# ../Schema/DIGINProfile_iec61968_part4_TransformerProductData_v026.xsd ">
	<m:ProductAssetModel>
		<m:mRID>14c5e1f9-7fd5-4a16-a3f5-99aa84bf63dc</m:mRID>
		<m:Names>
			<m:name>Distribution Transformer 0123</m:name>
		</m:Names>
		<m:modelNumber>0123_456</m:modelNumber>
		<m:Asset>
			<m:mRID>f67a819a-b118-4a6b-aa79-08d56645ab73</m:mRID>
			<m:serialNumber>T20210006</m:serialNumber>
			<m:Medium>
				<m:mRID>0a833542-2eb4-415d-a340-055dd75d7b63</m:mRID>
				<m:Names>
					<m:name>TransformerOil Type 4</m:name>
				</m:Names>
				<m:kind>mineralOil</m:kind>
				<m:volumeSpec unit="m3">370</m:volumeSpec></m:Medium></m:Asset>
		<m:AssetSpecification>
			<m:CoolingInfo>
				<m:mRID>58a69819-7538-4b2b-b655-f502012ebde2</m:mRID>
				<m:Names>
					<m:name>Cooling Option 2</m:name>
				</m:Names>
				<m:typeOfCooling>ONAN</m:typeOfCooling>
			</m:CoolingInfo>
			<m:MetricInfo>
				<m:mRID>2bdf3764-7d59-4404-9a53-8080617ffc51</m:mRID>
				<m:Names>
					<m:name>Metrics Transformer</m:name>
				</m:Names>
				<m:metricKind>Universal</m:metricKind>
				<m:productHeight unit="m" multiplier="m">1522</m:productHeight>
				<m:productLength unit="m" multiplier="m">1167</m:productLength>
				<m:productWeight unit="kg">1832</m:productWeight>
				<m:productWidth unit="m" multiplier="m">855</m:productWidth>
			</m:MetricInfo>
			<m:SoundInfo>
				<m:minSoundPressureLevel unit="dB">58</m:minSoundPressureLevel>
			</m:SoundInfo>
			<m:SurfaceTreatmentInfo>
				<m:galvanisationThickness unit="m" multiplier="micro">40</m:galvanisationThickness>
				<m:paintThickness unit="m" multiplier="micro">80</m:paintThickness>
			</m:SurfaceTreatmentInfo></m:AssetSpecification>
		<m:Manufacturer>
			<m:Organisation>
				<m:mRID>51889225-0507-42bb-8f1f-541aaee41024</m:mRID>
				<m:Names>
					<m:name>Manufacturer X inc</m:name>
				</m:Names></m:Organisation></m:Manufacturer>
		<m:AssetInfoContainer>
			<m:PowerTransformerInfo>
				<m:mRID>8b094f3b-8cbc-45e7-84d1-4409ae7164ea</m:mRID>
				<m:kind>transformer</m:kind>
				<m:TransformerTankInfos>
					<m:insulationKind>liquid-immersed</m:insulationKind>
					<m:TransformerEndInfos>
						<m:connectionKind>D</m:connectionKind>
						<m:endNumber>1</m:endNumber>
						<m:ratedS unit="VA" multiplier="k">500</m:ratedS>
						<m:ratedU unit="V" multiplier="k">22</m:ratedU>
						<m:EnergisedEndNoLoadTests>
							<m:mRID>222e67a7-6174-42d8-b5ba-fe0ab878efc8</m:mRID>
							<m:Names>
								<m:name>No Load Test 001</m:name>
							</m:Names>
							<m:energisedEndVoltage unit="V" multiplier="k">22</m:energisedEndVoltage>
							<m:loss unit="W">532</m:loss></m:EnergisedEndNoLoadTests>
						<m:EnergisedEndOpenCircuitTests>
							<m:mRID>75a1d8d6-dd4c-4b00-b7fc-6af4dc214feb</m:mRID>
							<m:Names>
								<m:name>Open Circuit Test 001</m:name>
							</m:Names>
							<m:energisedEndStep>5</m:energisedEndStep>
							<m:energisedEndVoltage unit="V" multiplier="k">22</m:energisedEndVoltage></m:EnergisedEndOpenCircuitTests>
						<m:EnergisedEndShortCircuitTests>
							<m:mRID>4e2acbbd-9b68-4768-882d-28f6d1276b3f</m:mRID>
							<m:Names>
								<m:name>Short Circuit Test 001</m:name>
							</m:Names>
							<m:power unit="VA">3978</m:power>
							<m:voltage>4.1</m:voltage></m:EnergisedEndShortCircuitTests></m:TransformerEndInfos>
					<m:TransformerEndInfos>
						<m:connectionKind>Yn</m:connectionKind>
						<m:endNumber>2</m:endNumber>
						<m:phaseAngleClock>11</m:phaseAngleClock>
						<m:ratedS unit="VA" multiplier="k">500</m:ratedS>
						<m:ratedU unit="V">415</m:ratedU>
						<m:GroundedEndShortCircuitTests>
							<m:mRID>4e2acbbd-9b68-4768-882d-28f6d1276b3f</m:mRID>
							<m:Names>
								<m:name>Short Circuit Test 001</m:name>
							</m:Names></m:GroundedEndShortCircuitTests>
						<m:OpenEndOpenCircuitTests>
							<m:mRID>75a1d8d6-dd4c-4b00-b7fc-6af4dc214feb</m:mRID>
							<m:Names>
								<m:name>Open Circuit Test 001</m:name>
							</m:Names>
							<m:openEndVoltage unit="V">415</m:openEndVoltage>
							<m:phaseShift unit="deg">30</m:phaseShift></m:OpenEndOpenCircuitTests></m:TransformerEndInfos>
				</m:TransformerTankInfos>
			</m:PowerTransformerInfo>
			<m:TapChangerInfo>
				<m:mRID>48f97f2c-a79e-4fd4-bf18-2cbf0ad873b8</m:mRID>
				<m:Names>
					<m:name>Tap Changer model 987</m:name>
				</m:Names>
				<m:kind>other</m:kind>
				<m:highStep>2</m:highStep>
				<m:lowStep>4</m:lowStep>
				<m:neutralStep>0</m:neutralStep>
				<m:stepVoltageIncrement>2.5</m:stepVoltageIncrement>
			</m:TapChangerInfo></m:AssetInfoContainer></m:ProductAssetModel></m:AssetCatalogue>
```
</p></details>

<br />


<!-- LICENSE -->
## License

Copyright (c) 2019 - 2021 DIGIN Energi, All Rights Reserved.

This program is free software and may be distributed according to the terms of the MIT License.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Prosjektleder: Stefan Kunz, Elvia

Email: stefan.kunz@elvia.no

DIGIN Project Link: [https://diginenergi.no/hva-gjor-vi/produktdata/](https://diginenergi.no/hva-gjor-vi/produktdata/)

GitHub Project Link: [https://github.com/digin-energi/Produktdata](https://https://github.com/digin-energi/Produktdata)


<br />



<!-- Verions -->
## Versioning

Following versions are available from DIGIN Produktdata

| Version | Type | Description  | 
|---|---|---|
| 027 | `beta` |  Multiplicity of MetricInfo are changed as pec IEC WG recommendation. minSoundPressureLEvel type is changed to Pressure because we are allowed to changed the initial value and multiplier and symbol. NEK attributes extensions are added to CableInfo, WireInfo, ShuntCompensator, OverheadWireInfo and SwitchInfo. Attribute LifecycleDate in Asset is added. TransformerTest attributes (basePower and temperature) are added.| 
| 026 | `beta` |  Some attributes are added to Asset class and it is generalized to NEKAsset class to incorporate other relevent attributes. | 
| 025 | `dev` |  AssetinfoContainer, AssetSpecification and related extension classes e.g. MetricInfo and power transformer product related classes were extended | 

The versioning of the file within Produktdata follow a scheme, that is:

DIGINProfile _ iec`CIMPackage` _ part`part#` _ `ProfileName/ProfileExtensionIdentifier` _ `cimversion` _ v`ABC` . `format`

### For example

DIGINProfile_iec61968_part4_AssetCatalogue_cim100_v001.xml
| Item | Description |
| --- | --- |
| `CIMPackage` | Corresponding CIM Package i.e., 61968 in the example
| `part#`| Corresponding part of the package which defines the profile which is under extension. Otherwise, if the developed profile is absolute new extension by DIGIN then the part of the package need to identified to which it can be closely related.
| `ProfileName/ ProfileExtensionIdentifier` | Name of the existing profile or newly created profile or a profile which only focus to specific extension within the profile identified as a scenario within a defined usecase.
| `cimversion` | The version of cim IEC TC57 metamodel, currently used verion is cim100
| `ABC` | Version number in three-digit format, e.g., v001 means version of the developement in produktdata # 0.0.1

Following rules shall be used to change the versioning numbers `ABC` :

| A | B | C |
| --- | --- | --- |
| Verified and approved version for the given profile or usecase scenario ition for target extension | Changes in Class, Enumeration class, Diagrams, and Package | Changes in Attribute, Enumeration literal, Association, and Association end |



<p align="right">(<a href="#top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[license-shield]: https://img.shields.io/badge/LICENSE-MIT-green
[license-url]: /License
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/company/digin-energi/
[product-screenshot]: images/screenshot.png



















