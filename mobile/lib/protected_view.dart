import 'dart:convert';
import 'dart:io';

import 'package:http/http.dart' as http;
import 'package:flutter/material.dart';
import 'package:mobile/user_manager.dart';

class ProtectedView extends StatelessWidget {
  final _userManager = UserManager();

  ProtectedView({super.key});

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
      future: _userManager.checkToken(),
      builder: (BuildContext context, AsyncSnapshot<bool> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Scaffold(
            body: Center(child: CircularProgressIndicator()),
          );
        } else if (snapshot.data == true) {
          return FutureBuilder<String?>(
            future: _userInfo(),
            builder: (context, AsyncSnapshot<String?> userSnapshot) {
              if (userSnapshot.hasData) {
                return Scaffold(
                  appBar: AppBar(title: const Text("Protected View")),
                  body: Center(
                      child: Text('You are logged in! ${userSnapshot.data}')),
                );
              } else {
                return CircularProgressIndicator();
              }
            },
          );
        } else {
          return const Scaffold(
            body: Center(child: Text("Unauthorized access!")),
          );
        }
      },
    );
  }

  Future<String> _userInfo() async {
    var path = Platform.isAndroid ? "http://10.0.2.2" : "http://127.0.0.1";
    var token = await _userManager.getUserToken();
    if (token != null) {
      var response = await http.get(
        Uri.parse('$path:5136/api/account/user-info'),
        headers: <String, String>{
          'Content-Type': 'application/json',
          'Authorization': 'Bearer $token',
        },
      );

      if (response.statusCode == 200) {
        var jsonResponse = jsonDecode(response.body);

        return jsonResponse['user'];
      } else {
        return "Problem";
      }
    } else {
      return "Unauthorized";
    }
  }
}
