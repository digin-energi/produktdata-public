<div id="top"></div>

[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![ValidationTool][validationtool-shield]][validationtool-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://diginenergi.no/">
    <img src="images/DIGIN_logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">The DIGIN program is the Norwegian grid operators' digitalisation initiative, where Norwegian DSOs, the TSO, regulator and others have joined forces to create the fundament for full digital interaction in both planning and operation of the electrical grid. 
  </h3>
  <p align="center">
    <a href="https://github.com/digin-energi/produktdata-public"><strong>Explore the sourcecode »</strong></a>
    <br />
    <a href="https://github.com/digin-energi/produktdata-public/issues">Report Bug</a>
    </p>
</div>

## XML validator

As a part of the Energy Norge project, DNV has developed a XML validator for validating a XML file against a XSD file. The validation results a written in a text file which can be opened and viewed by any text editor (e.g. notepad).

The validation can be done in 2 ways, with or without self-provided xml schema.

### Steps for using validation without self-provided xml schema:
 
<p align="center"><img src="images/validation without self-provided xml schema.png" width="500" ></p>

- Use the button behind textbox A to select a XML file on your disk which needs to be validated.
- Use the button behind textbox B to select a XSD file on your disk to use for validation.
- Use the button behind textbox C to provide a text file to write the validation results to.
- Use the button D (“Validate XML file with XSD”) to start validation.


 
### Steps for using validation with self-provided xml schema:

<p align="center"><img src="images/validation with self-provided xml schema.png" width="500" ></p>

- Use the button behind textbox A to select a XML file on your disk which needs to be validated.
- Use the button behind textbox B to select a XSD file on your disk to use for validation.
- Use the button behind textbox C to provide a text file to write the validation results to.
- If checkbox D is set checked the XML schema textbox E will get enabled.
- Use textbox E to enter a XML schema (or targetNamespace) to use during validation.
- Use the button F (“Validate XML file with XSD”) to start validation.

<!-- Verions -->
## Versioning

Following versions are available from DIGIN Produktdata

| Version | Type | Description  | 
|---|---|---|
| 1.0 | `release` |  First version  | 

<!-- LICENSE -->
## License

Copyright (c) 2021 DIGIN Energi, All Rights Reserved.

This program is free software and may be distributed according to the terms of the GNU General Public License (GPL).

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[license-shield]: https://img.shields.io/badge/LICENSE-MIT-green
[license-url]: /License
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/company/digin-energi/
[product-screenshot]: images/screenshot.png
[validationtool-shield]: https://img.shields.io/badge/DOWNLOAD-ValidationTool.exe-blue
[validationtool-url]: https://github.com/digin-energi/Produktdata/blob/PowerTransformer/validationtool/XmlXsdValidator.exe
