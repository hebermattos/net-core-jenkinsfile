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
                    powershell 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                script {
                    powershell 'dotnet build'
                }
            }
        }

        stage('Test') {
            steps {
                script {
                    powershell 'dotnet test'
                }
            }        
        }

        stage('Build & push image') {
            steps {
                withDockerRegistry([ credentialsId: "b4909509-9376-4c65-9f7f-473f5b522ef5", url: "" ]) {
                        powershell 'docker build -t hebermattos/weatherforecast .'
                        powershell 'docker push hebermattos/weatherforecast:lastest'
                    }                
            }        
        }    
    }
}