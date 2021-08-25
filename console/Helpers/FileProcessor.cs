using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using console.Models;
using console.Models.Input;
using console.Models.Results;

namespace console.Helpers
{
    public class FileProcessor
    {        
        private DirectoryInfo InputDir;
        private DirectoryInfo OutputDir; 
        private ReferenceData BaseInfo;

        public FileProcessor(AppConfig appConfig)
        {
            InputDir = new DirectoryInfo(appConfig.InputFolder);
            OutputDir = new DirectoryInfo(appConfig.OutFolder);

            using (var fileStream = File.Open(appConfig.DataFile,FileMode.Open))
            {   
                XmlSerializer serializer = new XmlSerializer(typeof(ReferenceData));
                
                BaseInfo = (ReferenceData)serializer.Deserialize(fileStream);          
            } 


        }

        public List<GenerationOutput> ProcessInput()
        {
            var toReturn = new List<GenerationOutput>();
            foreach(var fi in InputDir.GetFiles("*.xml"))
            {
                toReturn.Add(ProcessFile(fi));
            }
            return toReturn;
        }

        private GenerationOutput ProcessFile(FileInfo file)
        { 
            using (var fileStream = file.OpenRead())
            {   
                XmlSerializer serializer = new XmlSerializer(typeof(GenerationReport));
                XmlSerializer write = new XmlSerializer(typeof(GenerationOutput));
                
                var report = (GenerationReport)serializer.Deserialize(fileStream);

                var genOut = new GenerationOutput(report,BaseInfo);

                var path = $"{OutputDir.FullName}/{file.Name.Replace(file.Extension,"")}-Result{file.Extension}";  
                var writeFile = System.IO.File.OpenWrite(path);  
  
                write.Serialize(writeFile, genOut);  
                writeFile.Close();

                return genOut;
            } 
        }
    }
}