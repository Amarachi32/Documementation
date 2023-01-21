# In-House Code Documentation for Bezao Training🤷‍♀️

In this project,I created a training documentation  for a
  group of Trainee such that Classes, Methods,Properties, Enums etc. are annotated with a Document Attribute. This is a documented code so that each Trainee in the team can easily understand each steps taken and can in turn contribute to the repository. The Document Attribute takes one required parameter *"Description" and two optional Parameters "Input" and "Output"*
respectively. When **GetDocs()** is called it displays details of all codes documented throughout the assembly. We created a class library namespace and used it to define  our **DocumentAttribute** which is being referenced in the  executable project folder.

///The screenshot of the sample display of our output code shows the following:


***
	        public DocumentAttribute(string description)
        {
            Description = description;
        }

        public DocumentAttribute(string description, string input = "", string output = "")
        {
            Description = description;
            Input = input;
            Output = output;
        }

        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
***

## Software Development Summary😃👓👓
* **Technology**: C#👓
* **Framework**: .NET6
* **Project Type**: Console
* **IDE**: Visual Studio (Version 2022)
* **Paradigm or pattern of programming**: Object-Oriented Programming (OOP)
* **Data**:Documented code


**NOTE**:We have used the power of **reflection** in C# to get information about our documented code in the assembly. This repo is subject to future modifications.











