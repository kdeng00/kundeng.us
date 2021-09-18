import React from "react";
import Button from 'react-bootstrap/Button';
// If any, import CSS
// import styles from './Link.css'


function buttonStyling() {
  const styling = {
    padding: '20px 50px 20px 50px',
    margin: '100px 10px 0px 10px'
  };

  return styling;
}


function linkTypes() {
  var types = { "Url": 1, "Email": 2};

  return types;
}

function openLink(someLink, someType) {
  var myLink = "";

  switch(someType) {
    case 1:
      myLink = someLink;
      break;
    case 2:
      myLink = `mailto:${someLink}`;
      break;
  }

  window.open(myLink);
}

function githubButton() {
  const gitHubLink = "https://github.com/kdeng00";
  const someType = linkTypes().Url;

  const someChange = (myLink, goodType) => e => {
    openLink(myLink, goodType);
  };

 const myStyle = buttonStyling();

  return (
    <>
      <Button variant="light" style={myStyle} size="lg" onClick={someChange(gitHubLink, someType)}>GitHub</Button>{' '}
    </>
  )
}

function emailButton() {
  const emailAddress = "kundeng94@gmail.com";
  const someType = linkTypes().Email;

  const someChange = (myLink, goodType) => e => {
    openLink(myLink, goodType);
  };

 const myStyle = buttonStyling();

  return (
    <>
      <Button variant="light" style={myStyle} size="lg" onClick={someChange(emailAddress, someType)}>Email</Button>{' '}
    </>
  )
}


const Link = () => {
  const github = githubButton();
  const email = emailButton();

  return (
    <>
      <div className="mb-2">
        {github}
        {email}
      </div>
    </>
  );
};


export default Link;