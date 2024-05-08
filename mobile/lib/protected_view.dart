import 'package:flutter/material.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';

class ProtectedView extends StatelessWidget {
  final _storage = const FlutterSecureStorage();

  const ProtectedView({super.key});

  Future<bool> _checkToken() async {
    var token = await _storage.read(key: 'jwt');
    return token != null;
  }

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
      future: _checkToken(),
      builder: (BuildContext context, AsyncSnapshot<bool> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Scaffold(
            body: Center(child: CircularProgressIndicator()),
          );
        } else if (snapshot.data == true) {
          return Scaffold(
            appBar: AppBar(title: const Text("Protected View")),
            body: const Center(child: Text("You are logged in!")),
          );
        } else {
          return const Scaffold(
            body: Center(child: Text("Unauthorized access!")),
          );
        }
      },
    );
  }
}
