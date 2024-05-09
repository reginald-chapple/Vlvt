import 'package:flutter/material.dart';

class User {
  final String id;
  final String token;

  User({required this.id, required this.token});
}

class UserInfo {
  final String name;

  UserInfo({required this.name});
}

class UserProvider with ChangeNotifier {
  User? _user;

  User? get user => _user;

  void setUser(User user) {
    _user = user;
    notifyListeners();
  }

  void logout() {
    _user = null;
    notifyListeners();
  }
}

// Consumer<UserProvider>(
//   builder: (context, userProvider, child) {
//     final user = userProvider.user;
//     return Scaffold(
//       appBar: AppBar(title: Text("Home")),
//       body: user != null ? Text('Welcome, ${user.id}') : Text('Not logged in'),
//     );
//   },
// );