using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.DockerDemo
{
    //Advantages of Docker container
    //1. ROI & Cost Saving
    //      1.1. Can be as small as 10 MB
    //      1.2. No Additional OS Cost
    //      1.3. Almost no unused resources
    //      1.4. Really fast to start & stop
    //      1.5. Extreamly easy to create new container - together with orgestration technologies like kubernetes it's even more effective
    //2. Portability- Docker containers that run at any machine which supports Docker
    //3. Performance - It gives much better performance when compare to virtual machines
    //4. Isolation - It works in complete isolation. It has it's all dependencies
    //5. Scalablity - It can able to create new container very quickly

    // Core objective : Containerized our application to avail all the benefits that our listed. 
    // Docker : It's just a platform that helps us to package all our application into images and run them as container that any platform that can run on docker
    // Docker : It's basically containerization platform. This is essentially is a platform as a service product.

    //Docker Images

    //Images - In docker, everything is based on images. Images are the application bundled with all its dependencies. It basically includes the elements needed to run in application as a container.
    // Elements needed/required to run the application - OS, dev framework, env variables, application, database, config files, dependencies, libraries etc.,
    // docker -v, docker --version
    // Prebuild docker images are there in docker hub [hub.docker.com]
    // Docker Hub - Repository for holding docker images
    // > docker images or docker image ls - To see the images in local docker host
    // > docker pull mysql - Pull mysql from docker host
    // > docker run --name mysql_local -e MYSQL_ROOT_PASSWORD=dhilip mysql [Run mysql in a container]
    // > docker ps [ Mysql is running in a container ]
    // > docker exec -it mysql_local bash
    // > root@mdk: mysql -u root -p dhilip
    // > mysql> create database student_db;
    // > mysql> use student_db;
    // > mysql> create table student(id not null, name text);
    // > mysql> insert into student(id, name) values(1,'dhilip');
    // > mysql> select * from student;

    // How to list images
    // >docker image ls or docker images

    // Formatting image list
    // >docker image ls --format "{{.ID}},{{.Repository}}" - Display ID and Repository name separated by , for all the images without headers
    // >docker image ls --format "{{.ID}}:{{.Repository}}" - Display ID and Repository name separated by : for all the images without headers
    // >docker image ls --format "table {{.ID}}\t{{.Repository}}\t{{.TAG}}" - Display ID and Repository name along with TAG for all the images with headers 

    // Inspecting an image [display json format]
    // >docker image ispect mysql

    // Seeing history of an images
    // >docker image history mysql
    // >docker image history --formt "table {{.ID}}\t{{.CreatedSince}}" mysql

    // Remove Images
    // >docker rmi mysql or // >docker rmi f35
    // >docker image rm mysql mongo
    // >docker image rm -f mysql
    // >docker stop db [container name]
    // >docker stop 31 [container id]
    // >docker ps >docker ps -a >docker iamges
    // >docker rmi db >docker rm 31d[id]


    // Tagging an image with new version [container id : cd12345]
    // >docker run -it -d ubantu
    // >docker ps
    // >docker exec -it cd12345 bash
    // >root@mdk : mkdir TempFolder
    // >root@mdk : ls
    // >root@mdk : exit
    // >docker ps
    // >docker exec -it cd12345 bash
    // >root@mdk : exit
    // >docker commit cd12345 dockerforteaching/dhilip_ubuntu:1.0
    // >docker images
    // >docker push f1aaeddfgf [ Image Id : f1aaeddfgf] - this gives image doesn't exist locally with the tag f1aaeddfgf
    // >docker push dockerforteaching/dhilip_ubuntu:1.0 - requested access to the source is denied
    // >docker login [give user name and password]
    // >docker push dockerforteaching/dhilip_ubuntu:1.0 - requested access to the source is denied
    // >docker images
    // >docker rmi dockerforteaching/dhilip_ubuntu:1.0
    // >docker images [dockerforteaching/dhilip_ubuntu:1.0 got removed and will not in local now]
    // >docker pull dockerforteaching/dhilip_ubuntu:1.0
    // >docker run -it dockerforteaching/dhilip_ubuntu:1.0

    //Docker Containers - Container helps software to Run reliably when moved from one computing environment to  another

    // What problem container solves?
    //  Portability
    // Problem statement - Works in my machine but not in test environment, this could be a number of other reasons
    // Platform version mismatch, OS mismatch, some config file missed etc.,
    // How container will solve this problem
    // Docker Iamge -> Send image to test machine -> How does test machine run the application which is inside image -> that's where container comes into the picture
    // So in test machine spin up the container and run the application inside isolated environment. This container consist of an entire run time environment including the application - OS, dev framework, env variables, application, database, config files, dependencies, libraries etc.,
    // You can even send the image to the staging or production env. It will works all the same. Only req condition is all these env shd have installed docker env. 
    // In realtime env, how do you share these images? using docker hub, in general push it to docker hub. Anyone who wants to run the application, will pull it to their env, spin up a container and run the application in it. The app runs exactly the same the way it was run in the dev env.

    // Run the docker image into container
    //Step 1 : Pull the image from the docker hub  - > docker pull imageName
    //Step 2 : Run the image in a container -> docker run -d -p 9000:3000 imageName , >docker ps
    //Step 3 : docker stop container id, > docker ps
    //Step 4 : list stopped containers, >docker ps -a
    //Step 4 : Run the container again -> docker run -d -p 9000:3000 imageName , >docker ps

    //Time Saving
    // How fast it's spin up a container which ultimately save the time.

    //Cost Saving
    //Docker container enables efficient use of system resources
    // Server -> Operating system -> Docker Engine (Replaces Hypervisor) -> DE manages everything that required to interact with our container -> Run the application in isolated way.   


    //Angular - A Javascript framework to develop SPA [Single page application]
    // Angular JS - 2010 [Performance Issue] V1.x
    // Angular 2.0 - 2016 V2.0
    // Angular 3.0 - Skipped due to mis alignment of router package
    // Angular 4.0 - New release every 6 months
    // Angular 5-8
    // Angular 9.0
    // Angular 10.0

    // Angular CLI - to create angular application using boiler plate code
    // >npm install -g @angular/cli
    // >to use npm, we have to install nodejs - NodeJs is not needed in production environment but it is required in dev machine to intall the cli and all the dependencies of our project.
    // Typescript - It's most popular choice towrite javascript code in object oriented way
    // NodeJS - Transfile typescript into nateve javascript code. so that browser can understand it
    // Once angular application pass throught the development life cycle, you create a distribution build then those are just static files which can be served any of the web server or CDN and it doesn't require any nodejs instance

    // >npm install -g @angular/cli@latest - This will install the latest angular 
    //> ng --version : It will give you the information of CLI version
    //> ng new my-first-app [Create the angular application]
    // >ng serve [It compiles the application and development server is now listening 4200 port
    // Install VSCode, Open the angular project in vscode using vscode editor or use the command prompt to open the project, navigate to the folder where the angular application is and then use this command to open the project : >code .
    // > ng build, ng build --prod
    // > JIT [Just in Time] -> Development build -> ng build or ng server
    // > AOT [Ahead of Time] -> Production build -> ng build --prod



    //Angular 9 features
    //1. Smaller size [After build], High performance [ Angular 9 supports AOT in  and Better devemopment experience
    //2. Ivy - Released in Angular 9 and it's new code name of angular compiler that converts angular code into browser understandable code
    //         Previously Ivy is used to call as View Engine, Ivy - Angular 8 (optional), Angular 9 -Default, you can enable/disable in tsconfig.json file [enableIvy : true/false]
    //3. Faster Testing
    //4. Improved build time [Supports AOT compiler in development build]
    //5. Improved Type checking
    //6. Improved build errors
    //7. Better debugging
    //8. Improved Styling and Binding
    //9. Faster Localization
    //10. You tube player and google maps using Angular 9
    //11. Typescript 3.7 support

    //e2e -> end to end integration testing, e2e,karma.config.js, tsconfig.spec.json are related to testing
    //node_modules or ng modules -> which holds application related packages and libraries which the application depends
    //package.json -> All the dependencies that are needed to the application are defined in package.json file. It has reference of dependencies. Two types of dependencies 1. Dev and Prod dependencies. 
    //package-lock.json-> This has the exact tree that was generated when the package was installed which is defined in package.json file. It has history and detailed view of packages we have installed in our application. 
    //.editorconfig -> node related to the angular. It's related to the vscode config
    //angular.json->Angular cli config files. It provides project specific configuration defaults for build and development tools
    //main.ts -> entry point of the application which tell the engine where the application modules are exists
    //app.module.ts -> Bootstrapping the application. Define the root component
    //app.component.ts -> This is the root component which is displayed in index.html
    //Component -> Html, View and Css
    //Index.html -> This is the only page in our application and various components are dynamically loaded on this page.
    //TypeScript -> Its an open source developed and maintained by microsoft.Superset of Javacript and adds optional static type to the language.
    //polyfills.ts -> suppport for multiple browsers
    //assets folder -> stores images and other type of resources
    //app folder -> actual project files
    //style.css -> global css file
    //test.ts -> this is related to testing
    //favicon.ico -> This is displayed in the browser
    //environments folder -> one is dev and other one is production


    //VSCode extensions
    //1. Angular Essentials -> boiler plate code for snippet for typescript and html
    //2. Angular Files -> helps to generate component , services and other things
    //3. Auto Rename Tag -> Auto rename paired html tags. Automatically rename the closing tag
    //4. Bracket Pair Colorizer 2 -> gives different colors for opening and closing brackets
    //5. Intellisense for CSS class names in HTML -> provides intellisense for css

    //Generage a component using angular cli
    //ng generate component property-list or ng g c property-list

    //Directives - It's used to manipulate the content in the template.
    //1.Structureal - Change the DOM layout by adding and removing the DOM element in our HTML template
    //2.Attribute - Change the apperance or behaviour of an element but doesn't add/remove DOM element


    //Routing - Routing enables us to create a dictionary where we can map the urls to different components of our application
    //alertifyJS - to have nices notification feature in angular application
    //alertifyJS - npm install alertifyjs  --save

    class DockerExample
    {
    }
}
