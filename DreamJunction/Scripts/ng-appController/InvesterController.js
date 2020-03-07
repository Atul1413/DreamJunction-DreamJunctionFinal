/*
    Invester Controller 
   
*/
var app = angular.module("DreamJsApp", ["ngRoute"]);
var apiUrl = "http://localhost:44387/api/";//Hosted API Url
//Set Active Menu
app.controller("InvesterController", function ($scope, $http) {
    $scope.onSubmit = function (formsubmit) {        
        if (formsubmit.$invalid) {
            alert("Please enter all required field");
        }
        else {
            $scope.InvestorDetail = {};
            $scope.InvestorDetail.Id = 0;
            $scope.InvestorDetail.FirstName = $scope.FirstName;
            $scope.InvestorDetail.MobileNumber = $scope.MobileNumber;
            $scope.InvestorDetail.Email = $scope.Email;
            $scope.InvestorDetail.Password = $scope.Password;
          
            $scope.InvestorDetail = $scope.InvestorDetail;
            console.log(JSON.stringify($scope.InvestorDetail));
            $http({
                method: "post",
                url: apiUrl + "InvestorController/RegisterInvestor",
                datatype: "json",
                data: JSON.stringify($scope.InvestorDetail)
            }).then(function (response) {
               
            }).catch(function onError(error) {
                console.log(error);
            });

        }
    };
});