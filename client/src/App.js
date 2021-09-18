import React from 'react';
import logo from './logo.svg';
import Link from './Link';
import './App.css';
import { width } from 'dom-helpers';


class Greeting {
  constructor(message, subMessage) {
    this.message = message;
    this.subMessage = subMessage;
  }
}


class App extends React.Component {
  render() {
    const greet = new Greeting("Hi! I'm Kun Deng", "I'm a programmer");

    const AColoredLine = ({ color }) => (
      <hr
        style={{
          'color': color,
          'backgroundColor': color,
          'width': width,
          'box-shadow': '1px 1px 1px 1px #ffffff'
        }}
        />
    );

    const width = "85%";
    const color = "#ffffff";

    return (
      <div className="App">
        <header className="App-header">
          <h1>{greet.message}</h1>
          <h2>{greet.subMessage} {greet.name}</h2>
          <AColoredLine color={color} width={width} />
          <Link />
        </header>
      </div>
    );
  }
}

export default App;
