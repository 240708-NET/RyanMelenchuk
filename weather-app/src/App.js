import React from 'react';
import Weather from './Weather';
import weatherStyle from "./WeatherStyle.module.css";

const App = () => {
  return (
    <div className={weatherStyle.page}>
      <h1 className={weatherStyle.header}>Weather Forecast App</h1>
      <Weather />
    </div>
  );
};

export default App;