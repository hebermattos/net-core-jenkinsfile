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
                script {
                    docker.withRegistry('https://registry-1.docker.io/v2/', 'b4909509-9376-4c65-9f7f-473f5b522ef5') {
                        def customImage = docker.build("hebermattos/" + env.JOB_BASE_NAME + ":${env.BUILD_ID}")
                        customImage.push()
                        customImage.push('latest')
                    }
                }
            }        
        }    
    }
}