using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Airflow
{
    //Apache Airflow is an open source platform to build, schedule and monitor workflows.
    //Apache Airflow is an orchestrator allowing to execute your tasks at the right time in the right way in the right order.

    //Benefits
    //1.    Dynamic
    //2.    Scalability
    //3.    User Interface - Monitor, retry
    //4.    Extensible - 

    //Core components
    //1.    Wen server - Flask server with Gunicorn serving the UI
    //2.    Schedule - Daemon in charge of scheduling workflows
    //3.    Metastore - Database where metadata are stored
    //4.    Executor - Class defining how your tasks should be executed
    //5.    Worker - Process/ sub process executing your task

    //Main concepts or building blocks of airflow
    //1.    DAG - Direct Asyclic Graph. It's basically a graph directed with AG's with no loop. DAG is actually a data pipeline in Airflow.
    //2.    Operator -> Is reaaly wrapper around task around the sync you want to achieve, ex: connect database, insert data into database
    //      Action Operator, Transfer Operator, Sensor Operator

    //What airflow is not?
    // Not a data streaming solution neither a data processing framework

    // How airflow works?
    // One node architecture or single node architecture - this is mainly for development purposes
        // One Node -> Web server -> Metastore 
        // Scheduler -> Metastore, Scheduler -> Executor, Queue
        // Executor, Queue -> Metastore
    // Multinode Architecture






    class AirflowDemo
    {
    }
}
