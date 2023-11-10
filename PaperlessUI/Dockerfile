FROM node:latest
COPY ./src-ui /src/src-ui
WORKDIR /src/src-ui
RUN npm install -g @angular/cli
RUN npm ci
RUN npm run build
EXPOSE 4200
CMD ["ng", "serve", "--host", "0.0.0.0"]