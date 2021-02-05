using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Kafka
{
    //Architecture - On Prem or Cloud?

    //Data ingestion - Apache Spark or Kafka 
    //                 Kafka is better than Spark because of in memory process. Even though is faster but it will take lot of system resources.
    //                 So Kafka is better for real time streaming. Probabaly we can use C# program [Producer] to get the data from PI and produce this data using kafka
    //                 Write a program in Python to get the data from Kafka [subscriber], This will happen in airflow, so finally we will store Raw PI data and calculated data into MongoDB or Cassandra database according to the client need.
    

    class KafkaDemo
    {
    }
}
