var app = angular.module("app", []);
app.controller("appController", ['$scope', '$http', function ($scope, $http) {
    $scope.EmailExpression = /^[^\s@]+@[^\s@]+\.[^\s@]{2,}$/;
    $scope.mobile_No = /^(\+?(\d{1}|\d{2}|\d{3})[- ]?)?\d{3}[- ]?\d{3}[- ]?\d{4}$/;
    $scope.SubmitEnquiry = function () {
        //var Fname = angular.element(document.getElementById("Fname"));
  
        //var MobileNo = angular.element(document.getElementById("MobileNo"));
        //var Email = angular.element(document.getElementById("Email"));
        //var msg = angular.element(document.getElementById("msg"));
        //if (Fname.val() === "") {
        //    toastr["error"]("Please Enter First Name");
        //    Fname.focus();
        //    return;
        //}
        //if (msg.val() === "") {
        //    toastr["error"]("Please Enter Message");
        //    msg.focus();
        //    return;
        //}
        //if (Lname.val() === "") {
        //    toastr["error"]("Please Enter Last Name");
        //    Lname.focus();
        //    return;
        //}
        //if (MobileNo.val() === "") {
        //    toastr["error"]("Please Enter Mobile No.");
        //    MobileNo.focus();
        //    return;
        //}
        //if (Email.val() === "") {
        //    toastr["error"]("Please Enter Email");
        //    Email.focus();
        //    return;
        //}
       
        $http({
            url: '/Home/ContactEmail',
            method: 'post',
            data: $scope.EnquiryData
        }).then(function (d) {
            debugger;
            $scope.result = d.data;
            if ($scope.result.res === "1") {
                toastr["success"]("Enquiry Sent successfully");
                $scope.EnquiryData = null;

            }
            else {
                toastr["error"]("Enquiry not save");
            }
            }, function (error) {
                alert(error);
            toastr["error"]("Something Went Wrong");
        });
    };

}]);