vehicleApp.controller('vmlAddController', ['$scope', '$http', '$stateParams', '$window', '$rootScope', vmlAddController]);

function vmlAddController($scope, $http, $stateParams, $window, $rootScope) {

    $scope.dataAdd = {
        VehicleMakeId: undefined,
        Name: undefined,
        Abrv: undefined
    };
    
    $scope.addVehicleModel = function () {
        if ($scope.dataAdd.VehicleMakeId != null && $scope.dataAdd.Name != null && $scope.dataAdd.Abrv != null) {
            var obj = {
                VehicleMakeId: $scope.dataAdd.VehicleMakeId,
                Name: $scope.dataAdd.Name,
                Abrv: $scope.dataAdd.Abrv
            };

            $http.post('/api/VehicleModel/AddVml', obj).success(function (data) {
                $scope.response = data;
                $window.alert("Success");
            })
            .error(function (data) {
                $window.alert("Error! " + data.Message);
            });

            $scope.vmlAddForm.$setPristine(true);
            $scope.dataAdd.VehicleMakeId = null;
            $scope.dataAdd.Name = null;
            $scope.dataAdd.Abrv = null;
        }
        else {
            $window.alert("Potrebno je popuniti sva polja.");
        }

        
    }

    $scope.ispis = function () {
        console.log($scope.dataAdd.VehicleMakeId);
        var name = $scope.dataAdd.VehicleMakeId;;
        console.log(name);
        return $window.alert(name);
    }

    
}