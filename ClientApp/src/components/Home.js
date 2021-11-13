import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () 
  {
    return (
      <div>
        <h1>Startseite</h1>
        <p>React | Dotnet SPA Projekt </p>
        <p>Navigieren Sie bitte &uuml;ber das <u>Men&uuml; </u>oben rechts.</p>
        
      </div>
    );
  }
}
