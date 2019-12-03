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
                    bat 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                script {
                    bat 'dotnet build'
                }
            }
        }
    }
}