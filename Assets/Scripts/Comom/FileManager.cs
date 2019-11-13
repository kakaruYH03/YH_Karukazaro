using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class FileManager
{
    static public List<Person> LoadData(byte[] data)
    {
        List<Person> resultList = new List<Person>();

        Stream stream = new MemoryStream(data);
        StreamReader reader = new StreamReader(stream);

        string lineValue;

        while ((lineValue = reader.ReadLine()) != null)
        {

            string[] values = lineValue.Split(',');
            try
            {
                Person person = new Person(values[0], (values[1]), values[2]);
                resultList.Add(person);
            }
            catch (FormatException)
            {

            }
        }
        reader.Close();
        return resultList;
    }
}
