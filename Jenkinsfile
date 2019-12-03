pipeline {

    agent {
        node {
            label '' 
        }
    }

    stages {

        stage('Restore') {
            steps {
                script { 
                    powershell 'dotnet restore .\src\src.csproj'
                }
            }
        }

        stage('Build') {
            steps {
                script {
                    powershell 'dotnet build .\src\src.csproj'
                }
            }
        }
    }
}