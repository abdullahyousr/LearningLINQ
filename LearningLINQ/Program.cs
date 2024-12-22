using LearningLINQ.Filteration;

var cars = CarRepository.GetCars();

var query_1 =
    from car in cars
    where car.Make == "Ford" && car.Model == "Mustang"
    select car;

var query_2 =
    cars.Where((car, index) => car.Make == "Ford" && index == 2);

CarRepository.PrintCars(query_2);