import React from "react";

const List = (props) => {
  console.log(props);
  return (
    <div>
      <h2 className="city">{props.city.name}</h2>
      <h1 className="temp">{Math.round(props.city.temp -273)}°C</h1>
      <div className="flex">
        <img
          src={`https://openweathermap.org/img/wn/${props.city.icon}.png`}
          alt=""
          className="icon"
        />
        <div className="description">{props.city.weather}</div>
      </div>
      <div className="humidity">Humidity: {props.city.humidity}%</div>      
    </div>
  );
};

export default List;
