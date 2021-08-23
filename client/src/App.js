import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';


class Greeting {
  constructor(name, message) {
    this.name = name;
    this.message = message;
    this.subMessage = "My name is,";
  }
}

class App extends React.Component {
  render() {
    const greet = new Greeting("Kun Deng", "Hello World!");

    return (
      <div className="App">
        <header className="App-header">
          <h1>{greet.message}</h1>
          <h2>{greet.subMessage} {greet.name}</h2>
        </header>
      </div>
    );
  }
}

export default App;
