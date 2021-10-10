import api from "./api";

const getHistory = async () => {
  try {
    return await api.get(`/search/list-all`);
  } catch (error) {
    console.log(error);
  }
};

export default getHistory;