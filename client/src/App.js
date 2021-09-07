import React, { Component } from 'react';
import logo from './logo.svg';
import Link from './Link';
import './App.css';


class Greeting {
  constructor(message, subMessage) {
    this.message = message;
    this.subMessage = subMessage;
  }
}

class App extends React.Component {
  render() {
    const greet = new Greeting("Hi! I'm Kun Deng", "I'm a programmer");

    return (
      <div className="App">
        <header className="App-header">
          <h1>{greet.message}</h1>
          <h2>{greet.subMessage} {greet.name}</h2>
          <Link />
        </header>
      </div>
    );
  }
}

export default App;
