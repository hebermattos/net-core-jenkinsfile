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
                    docker.withRegistry('https://index.docker.io/v1/', 'credentials-id') {
                        def customImage = docker.build("hebermattos/" + env.JOB_BASE_NAME + ":${env.BUILD_ID}")
                        customImage.push()
                    }
                }
            }        
        }    
    }
}