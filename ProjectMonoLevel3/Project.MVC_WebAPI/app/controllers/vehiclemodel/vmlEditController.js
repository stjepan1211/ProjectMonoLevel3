angular.module('vehicleApp').controller('vmlEditController', ['$scope', '$http', '$stateParams', '$window', vmlEditController]);

function vmlEditController($scope, $http, $stateParams, $window) {

    var id = $stateParams.VmlId;

    $scope.editInit = function () {
        $http.get('/api/VehicleModel/GetVml?id=' + id).success(function (data) {
            $scope.data = data;
        })
        .error(function (data) {
            $window.alert("Error! " + data.Message);
        })
    }

    $scope.update = function () {
        if ($scope.Name != null && $scope.Abrv != null) {
            var vml = {
                Name: $scope.Name,
                Abrv: $scope.Abrv
            };
            $http.put('api/VehicleModel/UpdateVml?id=' + id, vml).success(function (data) {
                $window.alert("Updated");
            })
        }
        else {
            $window.alert("Potrebno je popuniti sva polja");
        }
    }
    $scope.ispis = function () {
        return $window.alert($scope.da)
    }
}
