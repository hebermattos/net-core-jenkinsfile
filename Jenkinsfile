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
                    docker.build $JOB_BASE_NAME + ":$BUILD_NUMBER"
                }
            }        
        }
    }
}