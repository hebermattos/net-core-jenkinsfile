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
                    docker.withRegistry('https://registry-1.docker.io/v2/', 'f07c8b6c-cf51-4cdc-a59f-e25d76af6298') {
                        def customImage = docker.build("hebermattos/" + env.JOB_BASE_NAME + ":${env.BUILD_ID}")
                        customImage.push()
                        customImage.push('latest')
                    }
                }
            }        
        }    
    }
}