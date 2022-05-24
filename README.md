# frontend
Projeto ASP .NET Core MVC que cria uma lista de objetos PizzaInfo e exibe as informações sobre Pizza em uma View

Dockerfile gerado no ambiente do VS 2022

Comando usado para gerar a imagem:  docker build -f frontend\Dockerfile -t pizzafrontend .

Arquivo de Deployment frontend-deploy.yml

apiVersion: apps/v1
kind: Deployment
metadata:
  name: pizzafrontend
spec:
  replicas: 1
  template:
    metadata:
      labels:
        app: pizzafrontend
    spec:
      containers:
      - name: pizzafrontend
        image: macoratti/pizzafrontend:latest
        ports:
        - containerPort: 80
        env:
        - name: ASPNETCORE_URLS
          value: http://*:80
  selector:
    matchLabels:
        app: pizzafrontend

subemeter o deploymento ao kubernetes: kubectl apply –f frontend-deploy.yml
    
Arquivo Service frontend-service.yml

apiVersion: v1
kind: Service
metadata:
  name: pizzafrontend
spec:
  type: NodePort
  selector:
     app: pizzafrontend
  ports:
    - port: 8080
      targetPort: 80
      
kubectl apply –f frontend-service.yml
     
minikube service pizzafrontend (falha ao executar)

kubectl port-forward service/pizzafrontend 7080:8080

http://localhost:7080


