import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import { Well } from "./components/well";
import App from './App';
import registerServiceWorker from './registerServiceWorker';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

ReactDOM.render(
  <BrowserRouter basename={baseUrl}>
    <App />

    <span id="footer">
    <div id="footer-orientation">
    <Well text="|    Copyright Benjamin Zipperer 2021 (Codebakery)  |"/>
    </div>
    </span>
  </BrowserRouter>,
   rootElement
  );

registerServiceWorker();

