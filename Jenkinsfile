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
                    bat 'dotnet restore .\src\src.csproj'
                }
            }
        }

        stage('Build') {
            steps {
                script {
                    bat 'dotnet build .\src\src.csproj'
                }
            }
        }
    }
}