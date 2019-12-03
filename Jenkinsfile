pipeline {

    agent {
        node {
            label '' 
        }
    }

    stages {

        // stage('Restore') {
        //     steps {
        //         script { 
        //             powershell 'dotnet restore'
        //         }
        //     }
        // }

        // stage('Build') {
        //     steps {
        //         script {
        //             powershell 'dotnet build'
        //         }
        //     }
        // }

        // stage('Test') {
        //     steps {
        //         script {
        //             powershell 'dotnet test'
        //         }
        //     }        
        // }

         stage('Build image') {
            steps {
                script {
                    powershell 'docker build -t ${env.JOB_BASE_NAME} .'
                }
            }        
        }
    }
}