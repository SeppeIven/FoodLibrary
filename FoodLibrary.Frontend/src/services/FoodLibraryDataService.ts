import http from "../http-common";

class FoodLibraryDataService {
  getAll() {
    return http.get("/FoodLibrary");
  }

  getNineRandomDishes() {
    return http.get("/FoodLibrary/NineRandom")
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

export default new FoodLibraryDataService();

export interface Dish {
  id: number;
  name: string;
  preparationTimeMinutes: number;
  meat: string;
  mealType: string;
}