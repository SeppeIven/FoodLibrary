import http from "../http-common";

class TutorialDataService {
  getAll() {
    return http.get("/FoodLibrary");
  }

  get(id: string) {
    return http.get(`/FoodLibrary/${id}`);
  }

  create(data: any) {
    return http.post("/FoodLibrary", data);
  }

  update(id: string, data: any) {
    return http.put(`/FoodLibrary/${id}`, data);
  }

  delete(id: string) {
    return http.delete(`/FoodLibrary/${id}`);
  }

  deleteAll() {
    return http.delete(`/FoodLibrary`);
  }

}

export default new TutorialDataService();