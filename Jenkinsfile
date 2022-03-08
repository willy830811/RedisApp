pipeline {
    agent any
    triggers {
        githubPush()
    }
    stages {
        stage('Restore packages'){
           steps{
               sh 'dotnet restore RedisApp.sln'
            }
         }
        stage('Clean'){
           steps{
               sh 'dotnet clean RedisApp.sln --configuration Release'
            }
         }
        stage('Build'){
           steps{
               sh 'dotnet build RedisApp.sln --configuration Release'
            }
         }
        stage('Publish'){
             steps{
               sh 'dotnet publish RedisApp.csproj --configuration Release'
             }
        }
    }
}