import http from "../http-common";

class FoodLibraryDataService {
  public async getAllDishes(): Promise<Dish[]> {
    const results = await http.get("/FoodLibrary");
    return results.data
  }

  public async getNineRandomDishes(): Promise<Dish[]> {
    const results = await http.get("/FoodLibrary/NineRandom");
    return results.data;
  }

  public async getDishByID(id: string): Promise<Dish> {
    const results = await http.get(`/FoodLibrary/${id}`);
    return results.data;
  }

  public async AddDish(data: any): Promise<Dish> {
    const results = await http.post("/FoodLibrary", data);
    return results.data;
  }

  public async updateDish(id: string, data: any): Promise<void> {
    await http.put(`/FoodLibrary/${id}`, data);
  }

  public async deleteDish(id: string): Promise<void> {
    await http.delete(`/FoodLibrary/${id}`);
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

export interface DishWithoutID {
  name: string;
  preparationTimeMinutes: number;
  meat: string;
  mealType: string;
}