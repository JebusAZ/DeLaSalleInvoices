import React from 'react';

interface Props{
  title:string,
  text:string
}

export default function App(props:Props){
  
  return(
    <div>
     <h1>{props.title}</h1>
      <div>
        {props.text}
      </div>
    </div>
  );
}
