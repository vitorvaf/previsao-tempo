
import api from './api';

const API_KEY = '0649a1d57566b8d5fbc8d9c1cae39adf';

const searchCity = async (cityName) => {
    try {

        const response = await api.get(`?q=${cityName}&appid=${API_KEY}`);
        return response;
        
    } catch (error) {

        console.log(error);
        
    }
    // api.get(`?q=${cityName}&appid=${API_KEY}`).then(response => {
    //     return response;
    // }).catch(erro => {
    //     console.log(erro)
    // })
}


export default searchCity;








