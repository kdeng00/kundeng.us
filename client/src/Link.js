import React from "react";
import { ButtonGroup } from "react-bootstrap";
import Button from 'react-bootstrap/Button';
// If any, import CSS


function githubButton() {
  return (
    <a href="https://github.com/kdeng00">
      <button variant="primary">
        GitHub
      </button>
    </a>
  )
}

function emailButton() {
  return (
    <a href="mailto:kundeng94@gmail.com">
      <button variant="primary">
        Email
      </button>
    </a>
  )
}


const Link = () => {
  const github = githubButton();
  const email = emailButton();

  return (
    <>
      <ButtonGroup>
        {github}
        {email}
      </ButtonGroup>
    </>
  );
};


export default Link;