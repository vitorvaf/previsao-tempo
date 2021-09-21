
import api from './api';

const API_KEY = '0649a1d57566b8d5fbc8d9c1cae39adf';

const searchCity = async (cityName) => {
    try {
        return await api.get(`?q=${cityName}&appid=${API_KEY}`);       
        
    } catch (error) {
        console.log(error);        
    }
}


export default searchCity;








