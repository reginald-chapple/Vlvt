import 'package:flutter_secure_storage/flutter_secure_storage.dart';

Future<String?> getToken() async {
  const _storage = FlutterSecureStorage();
  String? token = await _storage.read(key: 'jwt');
  return token;
}
