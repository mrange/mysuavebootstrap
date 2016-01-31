# suave.io on Azure

(based on [shanselman/suavebootstrapper](https://github.com/shanselman/suavebootstrapper))

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)

This repository shows how to use [FAKE](https://github.com/fsharp/FAKE), [Paket](https://github.com/fsprojects/Paket) and [KuduSync](https://github.com/projectkudu/KuduSync) to deploy a [suave.io](http://suave.io/) website to Azure.

## Getting started

* Go to http://azure.microsoft.com/ and create an Azure account
* Clone this repo and follow the setup steps from https://azuredeploy.net/
* Congratulations your first suave.io website is running on Azure!
* (Optional) Look at your Azure management portal and copy the deployment trigger url to the webhooks of your github repo.
   * This allows you to trigger deployments via `git push origin master`.

## Build locally

* Install dependencies with [PAKET](http://fsprojects.github.io/Paket/getting-started.html)
* Run ```build.fsx``` to build web server binary
* Or run ```fsi site/900.webserver.fsx```

## What's the difference with  Scott's bootstrap?

* Scott's bootstraps uses FAKE to execute FSI that executes the site (when I last checked)
* This bootstrap compiles using FAKE on deployment and then starts the compiled binary
