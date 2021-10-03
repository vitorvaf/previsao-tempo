import api from "./api";

const searchCity = async (cityName) => {
  try {
    return await api.get(`/search/getweather/?cityName=${cityName}`);
  } catch (error) {
    console.log(error);
  }
};

export default searchCity;
