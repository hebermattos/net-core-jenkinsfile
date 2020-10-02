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
                    docker.withRegistry('https://registry-1.docker.io/v2/', '98554180-4e47-4002-acd0-166a5fe01827') {
                        def customImage = docker.build("hebermattos/" + env.JOB_NAME.split('/')[0] + ":${env.BUILD_ID}")
                        customImage.push()
                        customImage.push('latest')
                    }
                }
            }        
        }    

        stage('Deploy') {
            steps {
                script {
                   powershell 'kubectl apply -f .\deployment.yml'
                }
            }        
        }  
    }
}