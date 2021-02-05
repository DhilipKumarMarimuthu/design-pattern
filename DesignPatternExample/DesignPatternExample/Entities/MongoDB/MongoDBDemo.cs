using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.MongoDB
{
    //MongoDB is a NoSql database. Schemaless database
    //Table - Collection, Record - Document
    //>show dbs - List the available databases
    //>use HR - It's created HR database on the fly and available to use. Also, it doesn't created any collection and documents at this point
    //>show dbs
    //>db.employee.insertOne({"name": "Dhilip", "emplid":1234, "salary":25000})
    //>db.employee.find()
    //>db.employee.find().pretty()
    //>db.employee.insertOne({"name": "Kumar", "emplid":2234, "salary":26000, "age":40,"hobbies": ["cricket", "chess"], "address":{"streetName":"Briar forest dr", "city":"houston", "zipcode":"77077"}})
    class MongoDBDemo
    {
    }
}
