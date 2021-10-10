FROM node:latest
# Diretório de trabalho(é onde a aplicação ficará dentro do container).
WORKDIR /app

# Instalando dependências da aplicação e armazenando em cache.
COPY app/package*.json /app/

RUN npm install 
RUN npm install react-scripts -g 

COPY ./ /app
# Inicializa a aplicação
CMD ["npm", "start"]

